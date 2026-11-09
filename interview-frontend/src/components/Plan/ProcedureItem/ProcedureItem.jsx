import React from "react";

const ProcedureItem = ({ procedure, handleAddProcedureToPlan, planProcedures }) => {
    return (
        <div className="py-2">
            <div className="form-check">
                <input
                    className="form-check-input"
                    type="checkbox"
                    value=""
                    id={`procedureCheckbox-${procedure.procedureId}`}
                    checked={
                        planProcedures.find(
                            (p) => p.procedureId === procedure.procedureId
                        )
                            ? true
                            : false
                    }
                    onChange={() => handleAddProcedureToPlan(procedure)}
                ></input>
                <label className="form-check-label" htmlFor={`procedureCheckbox-${procedure.procedureId}`}>
                    {procedure.procedureTitle}
                </label>
            </div>
        </div>
    );
};

export default ProcedureItem;
