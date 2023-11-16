namespace _30_Middleware
{
    public class MaintenanceMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly bool _isMaintenanceMode;

        public MaintenanceMiddleware(RequestDelegate next, bool isMaintenanceMode)
        {
            _next = next;
            _isMaintenanceMode = isMaintenanceMode;
        }

        public async Task Invoke(HttpContext context)
        {
            if (_isMaintenanceMode)
            {
                // Bakım modu aktifse, kullanıcıya bakım sayfasını göster
                context.Response.StatusCode = 503;
                await context.Response.WriteAsync("Site is currently in maintenance mode. Please check back later.");
            }
            else
            {
                // Bakım modu aktif değilse, request'i bir sonraki middleware'e iletle
                await _next(context);
            }
        }
    }
}
