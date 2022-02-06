using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
            }

            return Content("Hello from the comic books controller");
        }
    }
}
