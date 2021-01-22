using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smart_stock.Models
{
    public class Credentials
    {
        [Key]
        [Column(TypeName = "int(64)")]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string password { get; set; }
    }
}