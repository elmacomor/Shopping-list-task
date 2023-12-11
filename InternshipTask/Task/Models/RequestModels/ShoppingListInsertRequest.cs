using System.ComponentModel.DataAnnotations.Schema;

namespace TactaTask.Models.RequestModels
{
    public class ShoppingListInsertRequest
    {
        public int ShopperId { get; set; }
        public int ItemId { get; set; }
    }
}
