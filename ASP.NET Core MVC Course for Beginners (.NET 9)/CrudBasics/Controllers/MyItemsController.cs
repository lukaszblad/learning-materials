using Microsoft.AspNetCore.Mvc;
using CrudBasics.Data;
using Microsoft.EntityFrameworkCore;
using CrudBasics.Models;

namespace CrudBasics.Controllers
{
    public class MyItemsController : Controller
    {
        private readonly CrudBasicsContext? _context;
        public MyItemsController(CrudBasicsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var myItem = await _context.MyItems.ToListAsync();
            return View(myItem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Price")] MyItem item)
        {
            if(ModelState.IsValid)
            {
                _context.MyItems.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }
            return View(item);
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
