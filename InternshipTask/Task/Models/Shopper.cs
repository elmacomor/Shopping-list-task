using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TactaTask.Models
{
    public class Shopper
    {
        [Key]
        public int ShopperId { get; set; } 
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Surname { get; set; }
    }
}
