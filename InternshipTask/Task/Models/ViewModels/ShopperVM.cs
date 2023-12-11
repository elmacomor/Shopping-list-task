using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace TactaTask.Models.ViewModels
{
    public class ShopperVM
    {
        public int ShopperId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
