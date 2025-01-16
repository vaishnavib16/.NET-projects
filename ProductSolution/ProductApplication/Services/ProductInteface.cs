using ProductApplication.Models;

namespace ProductApplication.Services
{
    public interface ProductInteface
    {
        Product insert(Product product);
        Product update(Product product);

        List<Product> GetAll();

        Product delete(int Id);
    }
}
