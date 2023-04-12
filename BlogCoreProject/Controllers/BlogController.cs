using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
		var values = bm.TGetListWithCategory();
			return View(values);
		}

		public IActionResult ReadMore(int id)
		{
			var values = bm.TGetBlogByID(id);
			ViewBag.id1 = id;
		

			return View(values); 
		}
	}
}
