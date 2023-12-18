using System.ComponentModel.DataAnnotations.Schema;

namespace ALSAFA.Models
{
    public class item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        [ForeignKey("SubCategory")]
        public int SubID { get; set; }
        public SubCategory? SubCategory { get; set; }
    }
}
