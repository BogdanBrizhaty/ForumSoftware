using ForumSoftware.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using ForumSoftware.Models;
using AutoMapper;
using System.Security.Claims;
using ForumSoftware.BLL.DTO;
using ForumSoftware.Crosscutting;
using Microsoft.AspNet.Identity;

namespace ForumSoftware.Controllers
{
    public class AccountController : Controller
    {
        private IUserService UserService { get { return HttpContext.GetOwinContext().GetUserManager<IUserService>(); } }
        private IAuthenticationManager AuthManager { get { return HttpContext.GetOwinContext().Authentication; } }
        private IMapper _mapper = null;
        public AccountController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logoff()
        {
            //ViewBag.ReturnUrl = returnUrl;
            AuthManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }
        // 
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var userDto = new UserCredentialsDTO { UserName = model.UserName, Password = model.Password };
                //var userDto = _mapper.Map<UserCredentialsDTO>(model);
                ClaimsIdentity claim = await UserService.Authenticate(userDto);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    AuthManager.SignOut();
                    AuthManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterUserModel model)
        {
            // default role
            var defaultRoleName = "User";
            //await SetInitialDataAsync();
            if (ModelState.IsValid)
            {
                var userDto = new UserCredentialsDTO
                {
                    Email = model.Email,
                    Password = model.Password,
                    UserName = model.UserName,
                    Role = defaultRoleName
                };
                var profileDto = new UserProfileDTO
                {
                    JoinDate = model.JoinDate,
                    BirthDate = model.BirthDate,
                    Location = model.Location
                };
                OperationDetails operationDetails = await UserService.Create(userDto, profileDto);
                if (operationDetails.Succeeded)
                    return View("RegisterSuccess");
                else
                    ModelState.AddModelError(operationDetails.Error.PropertyName, operationDetails.Error.DescriptionMessage);
            }
            return View(model);
        }
    }
}