using BlogCoreProject.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
    public class WriterProfileController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public int WriterID()
        {
            var writeremail = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == writeremail).Select(y => y.WriterID).FirstOrDefault();
            return id;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var value = wm.TGetByID(WriterID());
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {

            wm.TUpdate(p);
            return View();

        }
    }
}
