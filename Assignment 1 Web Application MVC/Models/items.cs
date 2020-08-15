using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Web_Application_MVC.Models
{
    public class Items
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

    }
}
