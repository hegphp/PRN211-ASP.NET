using Microsoft.AspNetCore.Mvc;
using DemoWeb.Models;

namespace DemoWeb.Controllers {

    [BindProperties(SupportsGet =true)]
    public class ProductController : Controller {
        public void Default() { 
            
        }
        //[Route("/ProductList")]
        public string List() {
            int id = Convert.ToInt32(Request.Query["id"]);
            return "Action: List + Id = "+id;
        }

        public IActionResult Index() {
            return View(); //tra ve view mac dinh
        }

        public string DemoModelBinding(int id, string name) {
            return $"Action: DemoModelBinding, id: {id}, name: {name}";
        }

        public IActionResult MyAction() {
            return View("/Views/Product/Index.cshtml");
        }

        public string DemoDB(string id, string name) {
            return $"Action: DemoDB, id = {id}, name = {name}";
        }

        public IActionResult Detail(int id) {
            Product p = new Product(12, "ProductA");
            ViewData["id"] = id;
            ViewData["product"] = p;

            ViewBag.MyProduct = p;
            return View();
        }

        public IActionResult ProductInfo() {
            Product p = new Product(5, "Product 5");
            return View(p);
        }

        public IActionResult ProductList() {
            List<Product> productList = new List<Product>() {
                new Product(1,"Product 1"),
                new Product(2, "Product 2")
            };
            return View(productList);
        }
    }
}
