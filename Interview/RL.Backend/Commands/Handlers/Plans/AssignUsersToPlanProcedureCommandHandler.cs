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

            var plan = await _context.Plans.FirstOrDefaultAsync(p => p.PlanId == request.PlanId, cancellationToken);
            if (plan is null)
                return ApiResponse<Unit>.Fail(new NotFoundException($"PlanId: {request.PlanId} not found"));

            var procedure = await _context.Procedures.FirstOrDefaultAsync(p => p.ProcedureId == request.ProcedureId, cancellationToken);
            if (procedure is null)
                return ApiResponse<Unit>.Fail(new NotFoundException($"ProcedureId: {request.ProcedureId} not found"));

            var planProcedure = await _context.PlanProcedures
                .Include(pp => pp.PlanProcedureUsers)
                .FirstOrDefaultAsync(pp => pp.PlanId == request.PlanId && pp.ProcedureId == request.ProcedureId, cancellationToken);

            if (planProcedure is null)
                return ApiResponse<Unit>.Fail(new NotFoundException($"PlanProcedure with PlanId: {request.PlanId} and ProcedureId: {request.ProcedureId} not found"));

            if (distinctUserIds.Count > 0)
            {
                var existingUsers = await _context.Users
                    .Where(u => distinctUserIds.Contains(u.UserId))
                    .Select(u => u.UserId)
                    .ToListAsync(cancellationToken);

                var missingUsers = distinctUserIds.Except(existingUsers).ToList();
                if (missingUsers.Any())
                    return ApiResponse<Unit>.Fail(new NotFoundException($"UserId(s) not found: {string.Join(", ", missingUsers)}"));
            }

            // Remove unassigned users
            var usersToRemove = planProcedure.PlanProcedureUsers
                .Where(ppu => !distinctUserIds.Contains(ppu.UserId))
                .ToList();

            foreach (var userToRemove in usersToRemove)
            {
                planProcedure.PlanProcedureUsers.Remove(userToRemove);
            }

            // Add new assigned users
            var currentUserIds = planProcedure.PlanProcedureUsers.Select(ppu => ppu.UserId).ToHashSet();
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
        catch (Exception e)
        {
            return ApiResponse<Unit>.Fail(e);
        }
    }
}

