using Microsoft.AspNetCore.Mvc;

namespace EducalProjectT210.Areas.EducalAdmin.Controllers
{
    [Area("EducalAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
