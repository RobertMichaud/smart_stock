using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smart_stock.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "int(64)")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime JoinDate { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateAdded { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateConfirmed { get; set; }

        [Required]
        public Pii Pii { get; set; }

        [Required]
        public Credential Credential { get; set; }
    }
}