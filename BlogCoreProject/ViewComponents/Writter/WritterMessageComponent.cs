using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.ViewComponents.Writter
{
    public class WritterMessageComponent:ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            var values = mm.TGetListMessageWithWriter(8);
            return View(values);
        }
    }
}
