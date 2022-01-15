using EducalProjectT210.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducalProjectT210.Areas.EducalAdmin.Controllers
{
    [Area(nameof(EducalAdmin))]
    public class CategoryController : Controller
    {
        private readonly CourseDBContext _context;

        public CategoryController(CourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
