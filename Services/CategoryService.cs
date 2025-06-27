using BussinessObject;
using Repositories;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }
    }
}
