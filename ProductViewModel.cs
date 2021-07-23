using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_Project.Models
{
    public class ProductViewModel
    {
        [Key]
        [Required(ErrorMessage ="Enter Product Id")]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        [Range(1,10)]
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Enter Color")]
        public string Color { get; set; }

        public int Price { get; set; }
    }
}
