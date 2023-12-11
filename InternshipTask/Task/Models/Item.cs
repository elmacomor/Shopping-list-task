using System.ComponentModel.DataAnnotations;

namespace TactaTask.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
