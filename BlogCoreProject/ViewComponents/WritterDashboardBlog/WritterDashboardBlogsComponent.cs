using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.ViewComponents.WritterDashboardBlog
{
    public class WritterDashboardBlogsComponent:ViewComponent
    {
        Context c = new Context();
        public int WriterID()
        {
            var writeremail = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == writeremail).Select(y => y.WriterID).FirstOrDefault();
            return id;
        }
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var value = bm.GetListBlogWithWriterID(WriterID());
            return View(value);
        }
    }
}
