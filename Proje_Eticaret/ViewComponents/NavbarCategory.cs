using BusinessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_Eticaret.ViewComponents
{
    public class NavbarCategory : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.TGetList().Where(x => x.Status == true);
            return View(values);
        }
    }
}
