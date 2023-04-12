using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult AddComment(int id)
		{
			ViewBag.id1 = id;
			return PartialView();
		}

        [HttpPost]
        public PartialViewResult AddComment(Comment p)
        {
			p.CommentStatus = true;
			p.CommentDate = Convert.ToDateTime("2022-10-11 00:00:00.0000000");
			p.BlogID = 3;
			cm.TInsert(p);
			return PartialView();
        }
    }
}
