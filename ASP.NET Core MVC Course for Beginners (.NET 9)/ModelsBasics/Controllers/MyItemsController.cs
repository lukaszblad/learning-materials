using Microsoft.AspNetCore.Mvc;
using ModelsBasics.Models;

namespace ModelsBasics.Controllers
{
    public class MyItemsController : Controller
    {
        public IActionResult Overview()
        {
            var myItem = new MyItem() { Name = "keyboard" };
            return View(myItem);
        }

        public IActionResult EditItem(int id)
        {
            return Content("id = " + id);
        }
    }
}
