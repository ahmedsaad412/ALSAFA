using ALSAFA.IServices;
using ALSAFA.Models;
using ALSAFA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
//using System.Web.Mvc;

namespace ALSAFA.Controllers
{
    public class CategoryController : Controller        
    {
      
        
        private readonly ICategoryService _cat ;
        

        public CategoryController(ICategoryService Cat)
        {
            _cat = Cat;

        }
        // GET: CategoryController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var categories =await _cat.GetAllCategories();
                return View(categories);
        }

        // GET: CategoryController/Details/5
        [HttpGet]
        public async Task<ActionResult> Details(int id ) {

            var category = await _cat.GetCategory(id);
                return View(category);
          
        }

        // GET: CategoryController/Create
        [HttpGet]
        public ActionResult Create( )
        {

            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(string CName)
        {

            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
                var model = await _cat.CreateCategory(new Category() { CName = CName });
          
            return RedirectToAction("index");
        }

        // GET: CategoryController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var data = await _cat.GetCategory(id);
            return View(data);
            
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Category model)
        {
            Category? data = await _cat.GetCategory(id);
            if (data != null)
            {
                
                  data.CName = model.CName;
                    await _cat.SaveChanges();
            }
            return RedirectToAction("index");
        }

        // GET: CategoryController/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            await _cat.GetCategory(id);
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ApplyDelete(int id)
        {
            await _cat.DeleteCategory(id);
            return RedirectToAction("index");
        }
    }
}
