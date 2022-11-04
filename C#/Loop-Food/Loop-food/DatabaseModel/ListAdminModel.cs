using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loop_food.Models
{
    public class ListAdminModel
    {
        [Key]
        public int id_admin { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [MaxLength(45)]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string phone { get; set; } 
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string password { get; set; }
    }
}
