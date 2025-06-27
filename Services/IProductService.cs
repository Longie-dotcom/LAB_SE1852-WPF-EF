using BussinessObject;

namespace Services
{
    public interface IProductService
    {
        void DeleteProduct(Product p);
        Product GetProductById(int id);
        List<Product> GetProducts();
        void SaveProduct(Product p);
        void UpdateProduct(Product p);
    }
}
