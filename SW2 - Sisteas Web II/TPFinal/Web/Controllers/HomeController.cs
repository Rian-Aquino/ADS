using API.Models;
using Common.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UsuariosService _usuariosService= new UsuariosService("https://localhost:7166", new HttpClient());


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Credits()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Login,Senha")] LoginModel loginModel)
        {
            var res = await _usuariosService.Login(loginModel);

            if (res == null)
            {
                Response.ClearTokenCookie();
                return View("Login", loginModel);
            }

            Response.SaveTokenCookie(res.Token);

            return RedirectToAction("", "Produtos");
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            Response.ClearTokenCookie();
            return View("Login");

        }
    }
}