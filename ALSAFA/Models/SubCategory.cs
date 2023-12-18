using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ALSAFA.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<item>? items { get; set;}

        [ForeignKey("Category")]
        public int CatID { get; set; }
        public Category? Category { get; set; }
    }
}
