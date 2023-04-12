using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BlogCoreProject.ViewComponents.WritterDashboardBlog
{
    public class WriterDashboardAboutWriter:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public int WriterID()
        {
            var writeremail = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == writeremail).Select(y => y.WriterID).FirstOrDefault();
            return id;
        }
        public IViewComponentResult Invoke() {
            var value = wm.TGetAllList(WriterID());
            return View(value); 
        }
    }
}

    
