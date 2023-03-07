using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc0.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
