using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MattNyce.Models
{
    public class Product
    {
            public int Id { get; set; }

            [Required(ErrorMessage = "Please enter a name.")]
            [StringLength(30, ErrorMessage = "Title must be 30 characters or less.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please enter the price.")]
            [DataType(DataType.Currency)]
            [Range(1, 5000, ErrorMessage = "Please enter a price between 1 and 5000.")]
            public decimal Price { get; set; }

            [Required(ErrorMessage = "Please enter the quantity.")]
            [Range(0, 100, ErrorMessage = "Please enter a quantity between 0 and 100")]
            public int Quantity { get; set; }
        }
    }
