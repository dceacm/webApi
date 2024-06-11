using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
public abstract class BaseController : ControllerBase
{
    protected ProblemDetails GetNotFoundProblemDetails(string detail = "No se ha encontrado el recurso especificado.")
    {
        return new ProblemDetails
        {
            Status = StatusCodes.Status404NotFound,
            Title = "Not Found",
            Detail = detail,
            Instance = HttpContext?.Request?.Path,
            Type = "https://httpstatuses.com/404"
        };
    }

    protected ProblemDetails GetBadRequestProblemDetails(string detail = "El servidor no ha podido procesar la solicitud debido a un error de sintaxis.")
    {
        return new ProblemDetails
        {
            Status = StatusCodes.Status400BadRequest,
            Title = "Bad Request",
            Detail = detail,
            Instance = HttpContext?.Request?.Path,
            Type = "https://httpstatuses.com/400"
        };
    }

    protected ProblemDetails GetUnauthorizedProblemDetails(string detail = "No autorizado o credenciales inválidas.")
    {
        return new ProblemDetails
        {
            Status = StatusCodes.Status401Unauthorized,
            Title = "Unauthorized",
            Detail = detail,
            Instance = HttpContext?.Request?.Path,
            Type = "https://httpstatuses.com/401"
        };
    }

}