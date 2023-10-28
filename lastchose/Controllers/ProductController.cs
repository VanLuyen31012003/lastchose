using lastchose.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lastchose.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        WebsiteBanHangEntities1 objWebsiteBanHangEntities1 = new WebsiteBanHangEntities1();
        public ActionResult Detail(int Id)
        {
            var objProduct = objWebsiteBanHangEntities1.Products.Where(n=>n.Id==Id).FirstOrDefault();
            return View(objProduct);
        }
    }
}