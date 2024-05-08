using BusinessLogic.Abstract;
using CinemaPark.UI.Models;
using DAL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CinemaPark.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHallService _hallService;

        public HomeController(IHallService hallService )
        {
            _hallService = hallService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var Halls = await _hallService.GetHallListAsync();
            return View(Halls);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
