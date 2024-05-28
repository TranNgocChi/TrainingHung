using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [StringLength(100, ErrorMessage="Ko duoc qua 100")]
        [Required]
        public string? Name { get; set; }

        [StringLength(100, ErrorMessage = "Ko duoc qua 100")]
        [Required]
        public string? Description { get; set; }

    }
}
