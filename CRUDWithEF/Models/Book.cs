using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWithEF.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Author { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
