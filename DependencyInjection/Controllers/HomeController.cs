using System.Diagnostics;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RastgeleSayiServisi _rastgeleServis;

        public HomeController(ILogger<HomeController> logger, RastgeleSayiServisi rastgeleServis)
        {
            _logger = logger;
            _rastgeleServis = rastgeleServis;
        }

        public IActionResult Index()
        {
            //RastgeleSayiServisi servis = new RastgeleSayiServisi();
            //ViewBag.RastgeleSayi = servis.ZarAt();
            ViewBag.RastgeleSayi = _rastgeleServis.ZarAt();
            ViewBag.ServisinOlusturulmaZamani = _rastgeleServis.ServisinOlusturulmaZamani
                .ToString("yyyy-MM-dd HH:mm:ss.fff");
            return View();
        }

        public IActionResult Privacy()
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