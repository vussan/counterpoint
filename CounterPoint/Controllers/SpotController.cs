using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVC_POC.Controllers
{
    public class SpotController : Controller
    {
        private readonly ISpotService _spotService;
        public SpotController(ISpotService spotService)
        {
            _spotService = spotService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
            var spots = await _spotService.GetAll();
            return Content(JsonConvert.SerializeObject(spots), "application/json");
        }
    }
}
