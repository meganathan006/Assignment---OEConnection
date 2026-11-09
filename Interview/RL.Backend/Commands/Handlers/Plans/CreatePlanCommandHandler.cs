using MediatR;
using RL.Backend.Models;
using RL.Data;
using RL.Data.DataModels;

namespace RL.Backend.Commands.Handlers.Plans;

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, ApiResponse<Plan>>
{
    private readonly RLContext _context;

    public CreatePlanCommandHandler(RLContext context)
    {
        _context = context;
    }

    public async Task<ApiResponse<Plan>> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var plan = new Plan();
            _context.Plans.Add(plan);

            await _context.SaveChangesAsync();

            return ApiResponse<Plan>.Succeed(plan);
        }
        catch (Exception e)
        {
            return ApiResponse<Plan>.Fail(e);
        }
    }
}