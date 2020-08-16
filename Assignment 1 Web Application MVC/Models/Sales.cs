using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Web_Application_MVC.Models
{
    public class Sales
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Item { get; set; }
        public string BuyerName { get; set; }
        public int Quantity { get; set; }
    }
}
