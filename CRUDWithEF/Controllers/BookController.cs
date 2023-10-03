using Microsoft.AspNetCore.Mvc;

namespace CRUDWithEF.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
