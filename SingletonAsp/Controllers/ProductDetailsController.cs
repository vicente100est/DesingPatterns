using Microsoft.AspNetCore.Mvc;
using Tools.Earm;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //Factories
            CLocalEarnFactory localEarnFactory = new CLocalEarnFactory(0.20m);
            CForeignEarnFactory foreignEarnFactory = new CForeignEarnFactory(0.30m, 20);

            //Products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
