using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistics
{
    [Area("Admin")]
    public class Statistics4 : ViewComponent
    {
        AdminManager am = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            var values = am.TGetAllList(2);
            return View(values);
        }

    }
}
