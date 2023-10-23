using WebProject20_10_23.Models;

namespace WebProject20_10_23.Logic {
    public class ProductService {
        NorthWindContext _context;

        public ProductService() {
            _context = new NorthWindContext();
        }

        public List<Product> GetProductsByCateId(int cateId) {
            return _context.Products.Where(p => p.CategoryId == cateId).ToList();
        }
    }
}
