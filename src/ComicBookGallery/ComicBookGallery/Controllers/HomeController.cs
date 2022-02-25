using ComicBookGallery.Models;
using ComicBookGallery.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ComicBookRepository _comicBookRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _comicBookRepository = new ComicBookRepository();
        }

        public IActionResult Index()
        {
            ComicBook[] comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
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