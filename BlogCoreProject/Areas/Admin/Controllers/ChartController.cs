using BlogCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            list.Add(new CategoryModel
            {
                categorycount=21,
                categoryname="Elektronik"
            });

            list.Add(new CategoryModel
            {
                categorycount = 4,
                categoryname = "Ev Esyalari"
            });

            list.Add(new CategoryModel
            {
                categorycount = 7,
                categoryname = "Yemek"
            });

            list.Add(new CategoryModel
            {
                categorycount = 34,
                categoryname = "Paltar"
            });

            list.Add(new CategoryModel
            {
                categorycount = 14,
                categoryname = "Diger"
            });

            return Json(list);
        }
    }
}
