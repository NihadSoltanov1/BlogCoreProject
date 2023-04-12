using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogCoreProject.Controllers
{
    

    public class WritterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();
        public int WriterID()
        {
            var writeremail = User.Identity.Name;
            var id = c.Writers.Where(x => x.WriterMail == writeremail).Select(y => y.WriterID).FirstOrDefault();
            return id;
        }

        public IActionResult WriterPanelLayout()
        {
            return View();
        }

        public PartialViewResult WriterPanelNavbar()
        {
            return PartialView();
        }

        public IActionResult WriterPanel()
        {
           
            var value = bm.GetListBlogWithWriterID(WriterID());

            return View(value);
        }

        public PartialViewResult WriterFooterPanel()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalue = (from x in cm.TGetList()
                                                  select
                                                  new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.category1 = categoryvalue;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogThumbnailImage = "test6";
                p.BlogImage = "test6";
                p.BlogCreateDate = DateTime.Now;
                p.BlogStatus = true;
                p.WriterID = 8;

                bm.TInsert(p);
                return RedirectToAction("WriterPanel");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }

        public IActionResult BlogDelete(int  id)
        {
            var value = bm.TGetByID(id);
            bm.TDelete(value);
            return View("WriterPanel");
        }

        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            List<SelectListItem> categoryvalue = (from x in cm.TGetList()
                                                  select
                                                  new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.category1 = categoryvalue;            
            var values1 = bm.TGetBlogByID(id);
            
            return View(values1);
        }
        [HttpPost]
        public IActionResult BlogUpdate(Blog p)
        {
            return View();
        }
    }
}
