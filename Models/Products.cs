using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NSKStore.Models
{
    public class Products
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string? Description { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Category { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "int")]
        public int Stock {  get; set; }
        public string? ImagePath { get; set; }

    }
}
