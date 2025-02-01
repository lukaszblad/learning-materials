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

        public async Task<IActionResult> Edit(int id)
        {
            var item = await _context.MyItems.FirstOrDefaultAsync(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Price")] MyItem item)
        {
            if (ModelState.IsValid)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }
            return View(item);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.MyItems.FirstOrDefaultAsync(x => x.Id == id);
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.MyItems.FindAsync(id);
            if (item != null)
            {
                _context.MyItems.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToActionPermanent("index");
        }
    }
}
