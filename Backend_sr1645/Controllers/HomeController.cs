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

        [HttpGet]
        public IActionResult Index()
        {
            var produkty = db.Products.ToList();
            ViewBag.products = produkty;    

            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            if(product.Id > 0)
            {
                db.Products.Update(product);
            }
            else
            {
                db.Products.Add(product);
            }


            db.SaveChanges();

			var produkty = db.Products.ToList();
			ViewBag.products = produkty;

			return View();
        }

        public IActionResult Edit(int id)
        {
            var product = new Product();

            if(id > 0)
            {
                product = db.Products.Find(id);
            }

            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var produkt = db.Products.Find(id);

            if(produkt != null)
            {
                db.Products.Remove(produkt);
                db.SaveChanges();
            }

			var produkty = db.Products.ToList();
			ViewBag.products = produkty;

			return View("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}