using Microsoft.AspNetCore.Mvc;

namespace CinemaPark.UI.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
