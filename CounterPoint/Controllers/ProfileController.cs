using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository.Core.Models;
using Utils;

namespace CounterPoint.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IWebEmtService _webEmtService;

        public ProfileController(IWebEmtService webEmtService)
        {
            _webEmtService = webEmtService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var profiles = _webEmtService.GetAll().Result;
            return View(profiles);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
            var profiles = await _webEmtService.GetAll();
            return Content(JsonConvert.SerializeObject(profiles), "application/json");
        }

        [HttpPost]
        [Authorize]
        public ActionResult Add(string values)
        {
            var webEmt = new WebEmt();
            JsonConvert.PopulateObject(values, webEmt);

            _webEmtService.Add(webEmt);

            return View("Index");
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult> Update(int key, string values)
        {
            var profile = await _webEmtService.GetById(key);
            JsonConvert.PopulateObject(values, profile);

            _webEmtService.Update(profile);

            return View("Index");
        }

        [HttpDelete]
        [Authorize]
        public async Task<ActionResult> Delete(int key)
        {
            var profile = await _webEmtService.GetById(key);

            _webEmtService.Remove(profile);
            return View("Index");
        }
    }
}
