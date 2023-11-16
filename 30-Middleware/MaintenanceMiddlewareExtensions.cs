namespace _30_Middleware
{
    public static class MaintenanceMiddlewareExtensions
    {
        public static IApplicationBuilder UseMaintenanceMode(this IApplicationBuilder builder, bool isMaintenanceMode)
        {
            return builder.UseMiddleware<MaintenanceMiddleware>(isMaintenanceMode);
        }
    }
}
