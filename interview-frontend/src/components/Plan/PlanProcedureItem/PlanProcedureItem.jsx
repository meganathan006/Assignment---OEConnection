import React, { useState, useEffect } from "react";
import ReactSelect from "react-select";
import { assignUsersToPlanProcedure } from "../../../api/api";

const PlanProcedureItem = ({ planId, procedure, users, planProcedureUsers }) => {
    const [selectedUsers, setSelectedUsers] = useState([]);

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
    }, [planProcedureUsers, users]);

    const handleAssignUserToProcedure = async (e) => {
        const updated = e || [];
        setSelectedUsers(updated);
        const userIds = updated.map((u) => u.value);
        await assignUsersToPlanProcedure(planId, procedure.procedureId, userIds);
    };

    const handleRemoveAllUsers = async () => {
        setSelectedUsers([]);
        await assignUsersToPlanProcedure(planId, procedure.procedureId, []);
    };

    return (
        <div className="py-2">
            <div className="d-flex justify-content-between align-items-center">
                <div>{procedure.procedureTitle}</div>
                {selectedUsers && selectedUsers.length > 0 && (
                    <button
                        type="button"
                        className="btn btn-sm btn-outline-danger py-0 px-2"
                        style={{ fontSize: "0.75rem" }}
                        onClick={handleRemoveAllUsers}
                        title="Remove all assigned users"
                    >
                        Remove All
                    </button>
                )}
            </div>

            <ReactSelect
                className="mt-2"
                placeholder="Select User to Assign"
                isMulti={true}
                isClearable={true}
                options={users}
                value={selectedUsers}
                onChange={(e) => handleAssignUserToProcedure(e)}
            />
        </div>
    );
};

export default PlanProcedureItem;
