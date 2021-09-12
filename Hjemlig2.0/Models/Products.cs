using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hjemlig2._0.Models
{
    public class Products
    {

        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Max 25 tegn")]
        public string Name { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Max 25 tegn")]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        
        [StringLength(25, ErrorMessage = "Max 70 tegn")]
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
