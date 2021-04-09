using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zad1_ProgZaaw_MarekGajda.Models
{
    public class Devices
    {
        public int ID { get; set; }
        [Display(Name = "Typ urządzenia")]
        public string Type { get; set; }
        [Display(Name = "Producent")]
        public string Producer { get; set; }
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Odpowiedzialny użytkownik")]
        public string ReliableUser { get; set; }
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Display(Name = "Numer zamówienia")]
        public int Ticket { get; set; }
    }
}
