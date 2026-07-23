namespace WebApplication2.Middleware
{
    public class MyExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public MyExceptionMiddleware(RequestDelegate next) 
        { 
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // before
           await _next(context);
            //after
        }
    }
}
