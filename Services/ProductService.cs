using BussinessObject;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();    
        }

        public void DeleteProduct(Product p)
        {
            productRepository.DeleteProduct(p);
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public void SaveProduct(Product p)
        {
            productRepository.SaveProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            productRepository.UpdateProduct(p);
        }
    }
}
