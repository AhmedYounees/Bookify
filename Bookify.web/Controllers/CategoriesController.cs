using Microsoft.AspNetCore.Mvc;

namespace Bookify.web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public CategoriesController(ApplicationDbContext applicationDbContext)
        {
            _Context = applicationDbContext;
        }
 
        public IActionResult Index()
        {
            var categories = _Context.Categories.ToList();
            return View(categories);
        }
    }
}
