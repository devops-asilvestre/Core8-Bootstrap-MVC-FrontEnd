using Manager.UI.Models;
using Manager.UI.ViewModel.Account;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Manager.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }      
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ResendEmailConfirmation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        private IActionResult LoginOk(LoginViewModel model, string? returnUrl)
        {
            LoginViewModel telaVM = model;
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                    //return View($"{RaizView}/Login.cshtml", telaVM);
                }

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, change to shouldLockout: true
                var result = "Success";
                returnUrl = $"{this.HttpContext.Request.Scheme}://{this.HttpContext.Request.Host}/Home/index";
                switch (result)
                {
                    case "Success": return RedirectToAction("Index", "Home");
                    //case "Success1": return View($"/Views/Home/index.cshtml", new HomeViewModel()); //RedirectToAction(returnUrl);
                    case "LockedOut": return RedirectToAction("Lockout"); //View($"{RaizView}/Lockout");
                    case "RequiresVerification": return RedirectToAction($"SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                    case "Failure":
                    default:
                        {
                            ModelState.AddModelError("", "Tentativa de login inválida.");
                        }
                        return View($"Login.cshtml", telaVM);
                }
            }
            catch (Exception ex)
            {

                return View($"SendCode", telaVM);
            }
        }
    }
}
