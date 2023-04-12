using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.ViewComponents.WritterDashboardBlog
{
    public class WriterDashboardStatisticsComponent:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public int WriterID()
        {
            var writeremail = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == writeremail).Select(y => y.WriterID).FirstOrDefault();
            return id;
        }
        public IViewComponentResult Invoke()
        {
            var value1 = bm.TGetList().Count();
            var value2 = bm.GetListBlogWithWriterID(WriterID()).Count();
            ViewBag.blogcountwithwriter = value2;
            ViewBag.blogcount = value1;
            return View();
        }
    }
}
