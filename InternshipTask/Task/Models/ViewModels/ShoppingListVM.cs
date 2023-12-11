using System.ComponentModel.DataAnnotations.Schema;

namespace TactaTask.Models.ViewModels
{
    public class ShoppingListVM
    {
        public int ShoppingListId { get; set; }
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
