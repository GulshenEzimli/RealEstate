using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Web.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
