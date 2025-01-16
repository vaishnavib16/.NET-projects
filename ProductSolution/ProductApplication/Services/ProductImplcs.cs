using ProductApplication.Models;
using ProductApplication.Repository;

namespace ProductApplication.Services
{
    public class ProductImplcs : ProductInteface
    {

        private readonly ProductContext _context = new ProductContext();
        public Product delete(int Id)
        {
            var prod=_context.Products.Find(Id);
            _context.Products.Remove(prod);
            _context.SaveChanges();
            return prod;
        }

        public List<Product> GetAll()
        {
            var prod= _context.Products.ToList();
            return prod;
        }

        public Product insert(Product product)
        {
            var prod = _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product update(Product product)
        {
            var prodm = _context.Products.Update(product);
            _context.SaveChanges();
            return product ;
        }
    }
}
