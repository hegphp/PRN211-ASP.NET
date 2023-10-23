using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers {
    [BindProperties(SupportsGet = true)]
    public class OrderController : Controller {
        public IActionResult Index() {
            return View();
        }

        public string List(int id) { 
            return id == 0 ? GetOrderList() : GetOrderList(id);
        }

        public string GetOrderList() {
            return "Action: OrderList";
        }

        public string GetOrderList(int id) {
            return "Action OrderList, orderId = "+id;
        }

        [HttpGet("{controller}/list/{from}/{to}")]
        public string List(DateTime from, DateTime to) {
            return $"Action OrderList, from: {from}, to: {to}";
        }

        public string Detail(int id) { 
            return $"Action: View order details with id: {id}";
        }

        public string Edit(int id) {
            return $"Action: Edit order with id: {id}";
        }


    }
}
