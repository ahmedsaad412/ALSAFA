using System.ComponentModel.DataAnnotations;

namespace ALSAFA.Models
{
    public class Category
    {
       
            [Key]
            public int Id { get; set; }
            public string CName { get; set; } = null!;
            public List<SubCategory> SubCategories { get; set; } = null!;
        
    }
}
