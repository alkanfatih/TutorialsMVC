using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _27_ExceptionHanling.Exceptions
{
    public class MyExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Hata kayıt işlemleri
            //Log.Error(context.Exception, "Bir istisna oluştu.");

            if (!context.ExceptionHandled)
            {
                // Hata sayfasına yönlendirme
                context.Result = new ViewResult
                {
                    ViewName = "Error" // Hata sayfasının adını belirtin
                };

                context.ExceptionHandled = true;
            }
        }
    }
}
