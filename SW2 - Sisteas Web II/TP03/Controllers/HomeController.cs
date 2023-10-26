using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP03.Models;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Produtos");
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
    }
}