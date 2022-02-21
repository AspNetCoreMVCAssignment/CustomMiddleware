using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    public class QueryStringMiddleware
    {
        private RequestDelegate next;

        public QueryStringMiddleware(RequestDelegate _next)
        {
            next = _next;
        }
        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Method == HttpMethods.Get && context.Request.Query["fname"] == "nikunj")
            {
                await context.Response.WriteAsync("Message custom middleware");
            }
            await next(context);
        } 
    }
}
