import React, { useState, useEffect, useRef } from "react";
import ReactSelect from "react-select";
import { assignUsersToPlanProcedure } from "../../../api/api";

const PlanProcedureItem = ({ planId, procedure, users, planProcedureUsers }) => {
    const [selectedUsers, setSelectedUsers] = useState([]);
    const [error, setError] = useState(null);
    const [isSaving, setIsSaving] = useState(false);

    // Track the latest in-flight request so stale responses are ignored
    const pendingRequestId = useRef(0);

    // Populate from persisted data on load / when parent data changes
    useEffect(() => {
        if (planProcedureUsers && planProcedureUsers.length > 0) {
            const initial = planProcedureUsers.map((ppu) => {
                const matchedUser = users.find((u) => u.value === ppu.userId);
                return {
                    label: matchedUser?.label || ppu.user?.name || `User ${ppu.userId}`,
                    value: ppu.userId,
                };
            });
            setSelectedUsers(initial);
        } else {
            setSelectedUsers([]);
        }
        setError(null);
    }, [planProcedureUsers, users]);

    const handleAssignUserToProcedure = async (newSelection) => {
        const updated = newSelection || [];

        // Snapshot previous state so we can roll back on failure
        const previous = selectedUsers;

        // Optimistically update the UI immediately
        setSelectedUsers(updated);
        setError(null);
        setIsSaving(true);

        // Tag this request so an earlier slow response cannot overwrite a later one
        const requestId = ++pendingRequestId.current;

        try {
            const userIds = updated.map((u) => u.value);
            await assignUsersToPlanProcedure(planId, procedure.procedureId, userIds);
        } catch (err) {
            // Only roll back if this is still the latest request
            if (requestId === pendingRequestId.current) {
                setSelectedUsers(previous);
                setError("Failed to save user assignment. Please try again.");
            }
        } finally {
            if (requestId === pendingRequestId.current) {
                setIsSaving(false);
            }
        }
    };

    return (
        <div className="py-2">
            <div className="mb-1">
                <strong>{procedure.procedureTitle}</strong>
                {isSaving && (
                    <span className="ms-2 text-muted" style={{ fontSize: "0.75rem" }}>
                        Saving…
                    </span>
                )}
            </div>

            {error && (
                <div className="alert alert-danger py-1 px-2 mb-1" style={{ fontSize: "0.8rem" }} role="alert">
                    {error}
                </div>
            )}

            {/* isClearable provides "clear all" via the ✕ icon — no separate button needed */}
            <ReactSelect
                className="mt-1"
                placeholder="Select User to Assign"
                isMulti={true}
                isClearable={true}
                isDisabled={isSaving}
                options={users}
                value={selectedUsers}
                onChange={handleAssignUserToProcedure}
            />
        </div>
    );
};

export default PlanProcedureItem;
