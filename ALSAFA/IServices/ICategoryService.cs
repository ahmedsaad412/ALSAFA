using ALSAFA.Models;
using ALSAFA.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ALSAFA.IServices
{
    public interface ICategoryService
    {
        Task <IEnumerable<Category>> GetAllCategories();
        Task <Category?> GetCategory(int id);
        Task<Category> CreateCategory(Category category);
        Task<bool> DeleteCategory(int id);
        Task SaveChanges();

    }
}
