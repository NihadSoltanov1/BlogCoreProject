using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{

    public class WriterDashboardController : Controller
    {
        public IActionResult Index()
        {

            return View();
        
        }
    }
}
