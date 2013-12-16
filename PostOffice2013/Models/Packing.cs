using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Упаковка
    public class Packing
    {
        [Key]
        [Display(Name = "ID Покупки")]
        public int IDPurchase { get; set; }
        [Required]
        [Display(Name = "Вид упаковки")]
        public string KindOfPacking { get; set; }
        [Required]
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
        [Required]
        [Display(Name = "Количество")]
        public int Count { get; set; }
    }
}