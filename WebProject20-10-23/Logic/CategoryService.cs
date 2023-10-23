using WebProject20_10_23.Models;

namespace WebProject20_10_23.Logic {
    public class CategoryService {
        NorthWindContext _context;

        public CategoryService() {
            _context = new NorthWindContext();
        }

        public List<Category> GetCategories() {
            return _context.Categories.ToList();
        }
    }
}
