using ProductWebApp.Entity;

namespace ProductWebApp.Services
{
    public interface ProductInterface
    {
        Product Insert(Product product);
        Product Update(Product product);
        Product Delete(int Id);

        List<Product> GetAll();
    }
}