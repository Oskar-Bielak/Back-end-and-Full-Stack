using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loop_food.Models
{
    public class Restaurant
    {
        [Key]
        public int id_restaurant { get; set; }
        [Required]
        public string name_restaurant { get; set; }
        [Required]
        public string nip { get; set; }
        [Required]
        public string description_restaurant { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string mail_restaurant{ get; set; }
        [Required]
        public string MyProperty { get; set; }
    }
}
