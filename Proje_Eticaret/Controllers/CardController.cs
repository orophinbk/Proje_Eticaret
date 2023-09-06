using BusinessLayer.Context;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proje_Eticaret.Controllers
{
    public class CardController : Controller
    {
        CardManager cardManager = new CardManager(new EfCardDal());
        MyDbContext db = new MyDbContext();
        public IActionResult Index()
        {
            var values = cardManager.TGetList();
            return View(values);
        }
        public IActionResult CardAdd(int id)
        {
            var product = db.Products?.FirstOrDefault(x => x.ProductID == id);
            Card card = new Card();
            if (product != null)
            {
                card.ProductID = product.ProductID;
                card.ProductName = product.Name;
                card.Price = product.Price;
                card.ProductImage = product.Image;
                card.Quantity += 1;

                cardManager.TAdd(card);
            }

            return RedirectToAction("Index");
        }
        public IActionResult RemoveCard(int id)
        {
            var card = db.Cards?.FirstOrDefault(x => x.ProductID == id);

            if (card != null)
            {
                cardManager.TDelete(card);
            }
            return RedirectToAction("Index");
        }
    }
}
