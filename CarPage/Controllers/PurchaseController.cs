using Microsoft.AspNetCore.Mvc;

namespace CarPage.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}