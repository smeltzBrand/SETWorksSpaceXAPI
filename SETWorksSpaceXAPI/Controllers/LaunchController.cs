using Microsoft.AspNetCore.Mvc;
using SETWorksSpaceXAPI.Services.Interfaces;

namespace SETWorksSpaceXAPI.Controllers
{
    [Route("api/[controller]")]

    public class LaunchController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ILaunchJSONService _launchService;

        public LaunchController(ILaunchJSONService launchService, ILogger<WeatherForecastController> logger)
        {
            _launchService = launchService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var launchData = await _launchService.GetLaunchDataAsync();
            ViewBag.launchData = launchData;
            
            return View();
        }
    }
}
