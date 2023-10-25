using Microsoft.AspNetCore.Mvc;
using WebProject20_10_23.Logic;

namespace WebProject20_10_23.Controllers {
    public class ProductController : Controller {
        private ProductService productService = new ProductService();
        public IActionResult Index() {
            return View();
        }
        [Route("product/list/{cateId}")]
        public IActionResult List(int cateId) {
            return View(productService.GetProductsByCateId(cateId));
        }
        [Route("product/detail/{productId}")]
        public IActionResult Detail(int productId) {
            var p = productService.GetProductById(productId);
            return View(p);
        }
    }
}
