using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult Index()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Index(NewsLetter p)
        {
            p.MailStatus = true;
            nm.TInsert(p);
            return PartialView(p);
        }
    }
}
