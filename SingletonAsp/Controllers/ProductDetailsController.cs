using Microsoft.AspNetCore.Mvc;
using Tools.Earm;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailsController : Controller
    {
        private CLocalEarnFactory _localEarnFactory;
        private CForeignEarnFactory _foreignEarnFactory;
        public ProductDetailsController
            (
                CLocalEarnFactory localEarnFactory,
                CForeignEarnFactory foreignEarnFactory
            )
        {
            this._localEarnFactory = localEarnFactory;
            this._foreignEarnFactory = foreignEarnFactory;
        }
        public IActionResult Index(decimal total)
        {
            //Products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
