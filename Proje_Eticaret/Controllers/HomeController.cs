using BusinessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Proje_Eticaret.Models;
using System.Diagnostics;

namespace Proje_Eticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductManager productManager = new ProductManager(new EfProductDal());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        public IActionResult ProductReadAll(int id)
        {

            var values = productManager.GetProductByID(id);
            return View(values);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}