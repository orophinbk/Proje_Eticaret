using BusinessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Eticaret.Controllers
{
    public class ShopController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        public IActionResult ProductDetails(int id)
        {
            var values = productManager.GetProductByID(id);

            return View(values);
        }
    }
}
