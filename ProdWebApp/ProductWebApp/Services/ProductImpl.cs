using ProductWebApp.Entity;
using ProductWebApp.Repository;

namespace ProductWebApp.Services
{
    public class ProductImpl : ProductInterface
    {

        private readonly ProductContext _context = new ProductContext();
        public Product Delete(int Id)
        {
            using (var context = new ProductContext())
            {
                var prod = context.Products.Find(Id);
                context.Products.Remove(prod);
                context.SaveChanges();
                return prod;
            }

        }

        public List<Product> GetAll()
        {
            var prod = _context.Products.ToList();
            return prod;
        }

        public Product Insert(Product product)
        {
            using (var context = new ProductContext()) 
            { 
                var prod = context.Products.Add(product);
                context.SaveChanges();
                return product;
            }
        }

        public Product Update(Product product)
        {
            using (var context = new ProductContext())
            { 
                var prod = context.Products.Update(product);
                context.SaveChanges();
                return product;
            }
        }
    }
}
