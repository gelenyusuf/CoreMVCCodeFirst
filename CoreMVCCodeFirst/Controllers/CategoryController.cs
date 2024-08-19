using CoreMVCCodeFirst.Models.Categories.RequestModels;
using CoreMVCCodeFirst.Models.ContextClasses;
using CoreMVCCodeFirst.Models.Entıtıes;
using Microsoft.AspNetCore.Mvc;
using CoreMVCCodeFirst.Models.Categories.ResponseModels;
using CoreMVCCodeFirst.Models.Categories.PageVMs;
namespace CoreMVCCodeFirst.Controllers
{
    public class CategoryController : Controller
    {

        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateCategory()
        {
       
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel category)
        {

            Category c = new() { 
            
            CategoryName = category.CategoryName,
            Description = category.Description
            };
            _db.Categories.Add(c);
            _db.SaveChanges();
            return View();
        }
        public IActionResult GetCategories() {

            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel
            {
                CategoryName=x.CategoryName, Description =x.Description
            }).ToList();

            CategoryResponsePageVm crpm = new()
            {
                Categories = categories
            };
            return View(crpm);
        }
    }
}
