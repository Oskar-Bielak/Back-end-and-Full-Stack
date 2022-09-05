using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loop_food.Models
{
    public class NewsletterModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Podaj imię i nazwisko lub nazwe firmy")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Podaj maila")]
        public string Mail { get; set; }
        [Required(ErrorMessage ="Zadaj pytanie")]
        public string Text { get; set; }

    }
}
