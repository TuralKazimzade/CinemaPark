using BusinessLogic.Abstract;
using BusinessLogic.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NuGet.Protocol.Plugins;

namespace CinemaPark.UI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AdminController : Controller
    {
        private readonly IMovieService _movieService;

        public AdminController(IMovieService movieService)
        {
            _movieService = movieService;
        }

      

        [HttpGet]
        public async Task<IActionResult> Index()            
        {
            var movieList = await _movieService.GetMovieListAsync();
            return View(movieList);
        }
        [HttpPost ]
        public  async Task<JsonResult> AddMovie([FromBody] MovieListDto movieList)
         {
           

            await _movieService.AddMovieAsync(movieList);
            return Json(new { message="Movie added" });
        }

        
    }
}
