using MediatR;
using RL.Backend.Models;
using RL.Data.DataModels;

namespace RL.Backend.Commands;

public class CreatePlanCommand : IRequest<ApiResponse<Plan>>
{

}