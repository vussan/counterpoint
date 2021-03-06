using Serilog.Context;
using System.Security.Claims;
using System.Text;

namespace CounterPoint.Middlewares
{
    public class SerilogMiddleware
    {
        private readonly RequestDelegate _next;
        public SerilogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            LogContext.PushProperty("Endpoint", httpContext.Request.Path);
            LogContext.PushProperty("Method", httpContext.Request.Method);
            LogContext.PushProperty("QueryString", httpContext.Request.QueryString.Value);
            LogContext.PushProperty("RequestBody", GetRequestBody(httpContext).Result);
            LogContext.PushProperty("UserId", GetUserId(httpContext));
            await _next(httpContext);
        }

        private static long? GetUserId(HttpContext httpContext)
        {
            var claim = httpContext?.User as ClaimsPrincipal;
            var userId = claim.FindFirst("uid");
            if (userId == null)
                return null;
            else
                return long.Parse(userId.Value);
        }
        private static async Task<string> GetRequestBody(HttpContext httpContext)
        {
            HttpRequestRewindExtensions.EnableBuffering(httpContext.Request);
            Stream body = httpContext.Request.Body;
            byte[] buffer = new byte[Convert.ToInt32(httpContext.Request.ContentLength)];
            await httpContext.Request.Body.ReadAsync(buffer, 0, buffer.Length);
            string requestBody = Encoding.UTF8.GetString(buffer);
            body.Seek(0, SeekOrigin.Begin);
            httpContext.Request.Body = body;
            return requestBody;
        }

        
    }
}
