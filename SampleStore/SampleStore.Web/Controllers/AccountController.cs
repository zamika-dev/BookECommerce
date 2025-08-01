using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SampleStore.Domain.Entities;
using SampleStore.Domain.Enums;
using SampleStore.Web.Models;

namespace SampleStore.Web.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError("Register", error.Description);
                return View();
            }

            if (!await _roleManager.RoleExistsAsync(UserRoles.Customer.ToString()))
                await _roleManager.CreateAsync(new ApplicationRole { Name = UserRoles.Customer.ToString() });

            await _userManager.AddToRoleAsync(user, UserRoles.Customer.ToString());

            await _signInManager.SignInAsync(user, isPersistent: true);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel request, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View();

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                ModelState.AddModelError("Login", "نام کاربری یا رمز عبور اشتباه است");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password, isPersistent: true, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Login", "نام کاربری یا رمز عبور اشتباه است");
                return View();
            }

            if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return LocalRedirect(returnUrl);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
