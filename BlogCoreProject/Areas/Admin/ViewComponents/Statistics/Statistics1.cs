using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistics
{
    
    public class Statistics1 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var sumblog = c.Blogs.Count();
            var messagesum = c.Messages.Count();
            var sumcomment = c.Comments.Count();
            ViewBag.v1 = sumblog;
            ViewBag.v2 = messagesum;
            ViewBag.v3 = sumcomment;
            return View();
        }
    }
}
