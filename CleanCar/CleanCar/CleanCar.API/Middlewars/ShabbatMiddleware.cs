namespace CleanCar.API.Middlewars
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("midleware start");
            var shabbat = false;
            if (shabbat)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            await _next(context);

            Console.WriteLine("midleware end");


        }
    }
}
