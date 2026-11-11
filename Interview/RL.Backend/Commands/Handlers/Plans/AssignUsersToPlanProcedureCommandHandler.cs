using MediatR;
using Microsoft.EntityFrameworkCore;
using RL.Backend.Exceptions;
using RL.Backend.Models;
using RL.Data;
using RL.Data.DataModels;

namespace RL.Backend.Commands.Handlers.Plans;

public class AssignUsersToPlanProcedureCommandHandler : IRequestHandler<AssignUsersToPlanProcedureCommand, ApiResponse<Unit>>
{
    private readonly RLContext _context;

    public AssignUsersToPlanProcedureCommandHandler(RLContext context)
    {
        _context = context;
    }

    public async Task<ApiResponse<Unit>> Handle(AssignUsersToPlanProcedureCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Validate request
            if (request.PlanId < 1)
                return ApiResponse<Unit>.Fail(new BadRequestException("Invalid PlanId"));
            if (request.ProcedureId < 1)
                return ApiResponse<Unit>.Fail(new BadRequestException("Invalid ProcedureId"));
            if (request.UserIds is null)
                return ApiResponse<Unit>.Fail(new BadRequestException("UserIds cannot be null"));
            if (request.UserIds.Any(u => u < 1))
                return ApiResponse<Unit>.Fail(new BadRequestException("Invalid UserId"));

            var distinctUserIds = request.UserIds.Distinct().ToList();

            // A single query that validates PlanId + ProcedureId together and loads assigned users —
            // eliminates the separate Plan and Procedure round-trips.
            var planProcedure = await _context.PlanProcedures
                .Include(pp => pp.PlanProcedureUsers)
                .FirstOrDefaultAsync(pp => pp.PlanId == request.PlanId && pp.ProcedureId == request.ProcedureId, cancellationToken);

            if (planProcedure is null)
                return ApiResponse<Unit>.Fail(new NotFoundException(
                    $"PlanProcedure not found for PlanId: {request.PlanId}, ProcedureId: {request.ProcedureId}. " +
                    $"Ensure the procedure has been added to the plan first."));

            // Verify all requested UserIds exist
            if (distinctUserIds.Count > 0)
            {
                var existingUserIds = await _context.Users
                    .Where(u => distinctUserIds.Contains(u.UserId))
                    .Select(u => u.UserId)
                    .ToListAsync(cancellationToken);

                var missingUsers = distinctUserIds.Except(existingUserIds).ToList();
                if (missingUsers.Any())
                    return ApiResponse<Unit>.Fail(new NotFoundException(
                        $"UserId(s) not found: {string.Join(", ", missingUsers)}"));
            }

            // Remove users no longer in the requested set
            var usersToRemove = planProcedure.PlanProcedureUsers
                .Where(ppu => !distinctUserIds.Contains(ppu.UserId))
                .ToList();

            foreach (var userToRemove in usersToRemove)
                planProcedure.PlanProcedureUsers.Remove(userToRemove);

            // Add newly requested users
            var currentUserIds = planProcedure.PlanProcedureUsers
                .Select(ppu => ppu.UserId)
                .ToHashSet();

            foreach (var userId in distinctUserIds)
            {
                if (!currentUserIds.Contains(userId))
                {
                    planProcedure.PlanProcedureUsers.Add(new PlanProcedureUser
                    {
                        PlanId = request.PlanId,
                        ProcedureId = request.ProcedureId,
                        UserId = userId
                    });
                }
            }

            await _context.SaveChangesAsync(cancellationToken);

            return ApiResponse<Unit>.Succeed(new Unit());
        }
        catch (DbUpdateConcurrencyException)
        {
            // Another request modified the same record concurrently — surface a clear error
            // so the client can re-fetch and retry rather than silently overwriting.
            return ApiResponse<Unit>.Fail(new Exception(
                "The user assignment was modified by another request. Please refresh and try again."));
        }
        catch (Exception e)
        {
            return ApiResponse<Unit>.Fail(e);
        }
    }
}
