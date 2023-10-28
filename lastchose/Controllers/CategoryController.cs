using lastchose.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lastchose.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        WebsiteBanHangEntities1 objWebsiteBanHangEntities1 = new WebsiteBanHangEntities1();
        public ActionResult Index()
        {
            var listCategory = objWebsiteBanHangEntities1.Categories.ToList();
            return View(listCategory);
        }
        public ActionResult Productcategory(int Id)
		{
            var listProduct = objWebsiteBanHangEntities1.Products.Where(n => n.Categoryld == Id).ToList();
            return View(listProduct);
		}
    }
}