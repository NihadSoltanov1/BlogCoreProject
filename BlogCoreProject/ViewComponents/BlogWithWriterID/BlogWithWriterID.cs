using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.ViewComponents.BlogWithWriterID
{
    public class BlogWithWriterID:ViewComponent
    {
        BlogManager blog = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = blog.GetListBlogWithWriterID(7);
            return View(values);
        }
    }
}
