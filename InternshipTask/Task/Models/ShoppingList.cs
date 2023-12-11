using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TactaTask.Models
{
    public class ShoppingList
    {
        [Key]
        public int ShoppingListId { get; set; }
        [ForeignKey("ShopperId")]
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; }
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
