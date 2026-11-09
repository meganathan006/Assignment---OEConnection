using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RL.Backend.Models;

public class ApiResponse<T> where T : new()
{
    public bool Succeeded => Exception is null;
    public Exception? Exception { get; set; }
    public T? Value { get; set; }

    public static ApiResponse<T> Fail(Exception e)
    {
        return new ApiResponse<T>
        {
            Exception = e
        };
    }

    public static ApiResponse<T> Succeed(T value)
    {
        return new ApiResponse<T>
        {
            Value = value
        };
    }
}

public static class ApiResponseExtensions
{
    public static IActionResult ToActionResult<T>(this ApiResponse<T> response) where T : new()
    {
        if (!response.Succeeded)
            return new BadRequestObjectResult(response.Exception);
        else if (typeof(T) == typeof(Unit) || response.Value is null)
            return new OkResult();
        else
            return new OkObjectResult(response.Value);
    }
}