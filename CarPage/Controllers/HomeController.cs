using Microsoft.AspNetCore.Mvc;

namespace CarPage.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
      {
      return RedirectToAction("Index", "Car");
      }
    }
}