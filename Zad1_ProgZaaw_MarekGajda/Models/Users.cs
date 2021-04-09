using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Zad1_ProgZaaw_MarekGajda.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Display(Name = "Pseudonim")]
        public string Pseudo { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Rejestracji")]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "E-Mail")]
        public string Mail { get; set; }
        [Display(Name = "Wiek")]
        public decimal Age { get; set; }
    }
}
