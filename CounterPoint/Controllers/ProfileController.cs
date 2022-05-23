using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository.Core.Models;
using Utils;

namespace CounterPoint.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IWebEmtService _webEmtService;
        public ProfileController(IWebEmtService webEmtService)
        {
            _webEmtService = webEmtService;
        }

        public async Task<IActionResult> Index()
        {
            var profiles = await _webEmtService.GetAll();
            return View(profiles);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var profiles = await _webEmtService.GetAll();
            return Content(JsonConvert.SerializeObject(profiles), "application/json");
        }

        [HttpPost]
        public IActionResult Add(string values)
        {
            var webEmt = new WebEmt();
            JsonConvert.PopulateObject(values, webEmt);
            if (_webEmtService.GetByEmail(webEmt.Email).Result != null)
            {
                ViewData["Message"] = "Email already Exists";
                return View("Index");
            }
            _webEmtService.Add(webEmt);

            var code = EncryptionUtility.Encrypt(webEmt.Code.ToString());
            var link = $"{Config.Domain}Account/SetPassword/{code}";
            var email = new Email
            {
                Subject = "Account Activation",
                Destinations = new List<string>() { webEmt.Email },
                Body = $"Hello <b>{webEmt.FirstName} {webEmt.LastName}</b>,"
            };
            email.Body += "<br/>Click the link below to verify your account and set the password.";
            email.Body += $"<br/><b><a href='{link}'><b>Verify Account</b></a>";
            email.Body += "<br/><br/><small><i>This email was sent by the CSI Electronic Affidavit System. If you have not made this request, please ignore this email.</i></small>";

            MailUtility.SendMail(email);
            return View("Index");
        }

        [HttpPut]
        public async Task<IActionResult> Update(int key, string values)
        {
            var profile = await _webEmtService.GetById(key);
            JsonConvert.PopulateObject(values, profile);

            _webEmtService.Update(profile);
            return View("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int key)
        {
            var profile = await _webEmtService.GetById(key);

            _webEmtService.Remove(profile);
            return View("Index");
        }
    }
}
