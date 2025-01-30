using Microsoft.AspNetCore.Mvc;
using RazorBasics.Models;

namespace RazorBasics.Controllers
{
    public class MyItemsController : Controller
    {
        public IActionResult Overview()
        {
            var myItem = new MyItem() { Name="keyboard" };
            return View();
        }
    }
}
