using ALSAFA.IServices;
using ALSAFA.Models;
using Microsoft.EntityFrameworkCore;

namespace ALSAFA.Services
{
    public class MainService : IMainService
    {
        private readonly MyStoreDB _db;

        public MainService(MyStoreDB db)
        {
            _db = db;
        }

        public async Task<List<Category>> GetAllCategory()
        {
            var categories = await _db.Categories.Include(c=> c.SubCategories)
                .ThenInclude(sub=> sub.items).ToListAsync();

            return categories;
        }
    }
}
