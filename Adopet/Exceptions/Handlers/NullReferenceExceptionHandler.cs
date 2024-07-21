using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Adopet.Exceptions.Handlers;

public class NullReferenceExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, 
        Exception exception, 
        CancellationToken cancellationToken)
    {
        if (exception is not NullReferenceException)
        {
            return false;
        }

        var detalhes = new ProblemDetails
        {
            Title = "Falha ao encontrar objeto solicitado!",
            Status = StatusCodes.Status404NotFound,
            Detail = exception.Message
        };

        httpContext.Response.StatusCode = detalhes.Status.Value;

        await httpContext.Response.WriteAsJsonAsync(detalhes);

        return true;

    }
}
