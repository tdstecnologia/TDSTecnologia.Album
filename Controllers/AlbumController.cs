using Microsoft.AspNetCore.Mvc;
using TDSTecnologia.FaceAlbum.Web.Data;
using TDSTecnologia.FaceAlbum.Web.Models;

namespace TDSTecnologia.FaceAlbum.Web.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AppContexto _context;

        public AlbumController(AppContexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Album album)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

    }
}
