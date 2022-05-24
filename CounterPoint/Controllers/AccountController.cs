using AutoMapper;
using Business.Abstract;
using Business.DTOs;
using CounterPoint.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Core.Models;
using System.Security.Claims;
using Utils;

namespace CounterPoint.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IWebEmtService _webEmtService;
        private readonly IMapper _mapper;
        public AccountController(IAccountService accountService, IWebEmtService webEmtService, IMapper mapper)
        {
            _accountService = accountService;
            _webEmtService = webEmtService;
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            return View();
        }

        [Authorize]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var response = await _accountService.AuthenticateUser(model.Username, model.Password);
            if (!response.IsSuccess)
            {
                ViewData["Message"] = response.Message;
                return View();
            }

            var user = response.Data;
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, value: user.WebEmtcode.ToString()));
            claims.Add(new Claim(ClaimTypes.Role, user.RoleId.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, user.Email.ToString()));

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var props = new AuthenticationProperties();
            props.IsPersistent = model.RememberMe;
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            return RedirectToAction("Index", "Profile");
        }

        public IActionResult Register()
        {
            return View("Register");
        }


        [Route("[Controller]/[Action]/{code}")]
        public async Task<IActionResult> SetPassword(string code)
        {
            try
            {
                var webEmtCodeInString = EncryptionUtility.Decrypt(code);
                var webEmtCode = int.Parse(webEmtCodeInString);
                var webEmt = await _webEmtService.GetById(webEmtCode);
                if (webEmt == null)
                    return RedirectToAction("Login", "Account");

                return View(webEmt);
            }
            catch (Exception)
            {
                return RedirectToAction("Login", "Account");
            }

        }


        [HttpPost]
        public IActionResult CreateUser(AccountDTO user, string encryptedCode)
        {
            var webEmtCodeInString = EncryptionUtility.Decrypt(encryptedCode);
            if (webEmtCodeInString != user.WebEmtcode.ToString())
                return View("Error");

            var accountUser = _mapper.Map<UserAccount>(user);
            accountUser.EmailConfirmed = true;
            accountUser.IsActive = true;
            accountUser.RoleId = 1;

            _accountService.Add(accountUser);
            return RedirectToAction("Login", "Account");
        }
    }
}
