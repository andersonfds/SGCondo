using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace SGCondo.API.Infra.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync($"error ({context.Response.StatusCode})");
        }
    }
}
