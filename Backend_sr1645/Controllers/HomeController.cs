using Backend_sr1645.DAL;
using Backend_sr1645.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend_sr1645.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ShopContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            var produkty = db.Products.ToList();
            ViewBag.products = produkty;    

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