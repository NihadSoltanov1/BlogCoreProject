using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics2 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var lastblog = c.Blogs.OrderByDescending(x => x.BlogID).Take(1).Select(x=>x.BlogTitle).FirstOrDefault();
            ViewBag.v1 = lastblog;
            return View();
        }
    }
}
