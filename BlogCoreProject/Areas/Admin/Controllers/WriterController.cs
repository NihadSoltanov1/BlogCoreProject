using BlogCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {

         public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonwriter = JsonConvert.SerializeObject(wmlist);

            return Json(jsonwriter);
        }

        public static List<WriterModel> wmlist = new List<WriterModel>()
        {
            new WriterModel{WriterID=1,WriterName="Huseyin"},
                        new WriterModel{WriterID=2,WriterName="Eli"},
            new WriterModel{WriterID=3,WriterName="Mehemmed"},
            new WriterModel{WriterID=4,WriterName="Zamiq"},
            new WriterModel{WriterID=5,WriterName="Kenan"},

        };

        public IActionResult GetWriterByID(int wid)
        {
            var value = wmlist.FirstOrDefault(x => x.WriterID == wid);
            var jsonvalue = JsonConvert.SerializeObject(value);
            return Json(jsonvalue);
        }


        [HttpPost]
        public IActionResult AddWriter(WriterModel wm)
        {
            wmlist.Add(wm);
            var jsonwriter = JsonConvert.SerializeObject(wm);
            return Json(jsonwriter);
        }
        public IActionResult DeleteWriter(int id)
        {
            var value = wmlist.FirstOrDefault(x => x.WriterID == id);
            wmlist.Remove(value);
            return Json(value);

        }


        public IActionResult UpdateWriter(WriterModel wm)
        {
            var values = wmlist.FirstOrDefault(x => x.WriterID == wm.WriterID);
            values.WriterName = wm.WriterName;
            var jsonupwriter = JsonConvert.SerializeObject(wm);
            return Json(jsonupwriter);
        }
    }
}
