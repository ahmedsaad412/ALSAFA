using ALSAFA.IServices;
using ALSAFA.Models;
using Microsoft.EntityFrameworkCore;

namespace ALSAFA.Services
{
    public class CategoryService :ICategoryService
    {
        private readonly MyStoreDB _db;

        public CategoryService(MyStoreDB db)
        {
            _db=db;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categories = await _db.Categories.Include(c => c.SubCategories)
                .ThenInclude(sub => sub.items).ToListAsync();

            return categories;
        }

        public  async Task<Category?> GetCategory(int id)
        {
            var categories = await _db.Categories.FirstOrDefaultAsync(a=>a.Id== id);
            return categories;
        }


        public async Task<Category> CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            await  _db.SaveChangesAsync();
            return category;
        
        }
        public async Task<bool> DeleteCategory(int id)
        {
            var product = _db.Categories.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                _db.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }
    }
}
