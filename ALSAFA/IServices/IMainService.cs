using ALSAFA.Models;

namespace ALSAFA.IServices
{
    public interface IMainService
    {
        Task<List<Category>> GetAllCategory(); 
    }
}
