using Microsoft.AspNetCore.Mvc;

namespace RealEstate_API.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
