using System.Collections.Generic;
using System.Security.Claims;
using EcommerceMVC.Implementation.Service;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService UserService)
        {
            _userService = UserService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        public IActionResult UserLogin(UserLoginReqestModel userLoginReqestModel)
        {
            var userLoginResponse = _userService.Login(userLoginReqestModel);
            if (userLoginResponse.Status == false)
            {
                TempData["Failed"] = userLoginResponse.Message;
                return View("Login");
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role,userLoginResponse.Data.Role.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,userLoginResponse.Data.Id.ToString()),
                    new Claim(ClaimTypes.Name,userLoginReqestModel.Email)
                };

            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperties = new AuthenticationProperties();
            var principal = new ClaimsPrincipal(claimIdentity);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

            // HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

            if (userLoginResponse.Data.Role == Enums.UserRoleType.Admin)
            {

                return RedirectToAction("Index", "Product");
            }
            if (userLoginResponse.Data.Role == Enums.UserRoleType.Customer)
            {
                return RedirectToAction("DisplayProducts", "Product");
            }
            return RedirectToAction("Create", "Product");


        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }

    }
}
