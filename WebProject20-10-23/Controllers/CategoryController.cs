using Microsoft.AspNetCore.Mvc;
using WebProject20_10_23.Logic;

namespace WebProject20_10_23.Controllers {
    public class CategoryController : Controller {
        private CategoryService CategoryService = new CategoryService();
        public IActionResult Index() {
            ViewData["cateList"] = CategoryService.GetCategories();
            return View("/Views/Category/Index.cshtml");
        }
    }
}
