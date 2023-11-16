using _24_OptionsPattern.Classes;
using _24_OptionsPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace _24_OptionsPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings, IConfiguration configuration)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
            _configuration = configuration;
        }

        public IActionResult Options()
        {
            string key = _appSettings.AppKey;
            int value = _appSettings.AppValue;

            return Content($"Options Key: {key} - Value: {value}");
        }

        public IActionResult Index()
        {
            //return Content("Hoş Geldiniz: " + _configuration.GetValue<string>("WebTitle"));
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}