using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Марка
    public class Brand
    {
        [Key]
        [Display(Name = "ID Покупки")]
        public int IDPurchase { get; set; }
        [Required]
        [Display(Name = "Тип марки")]
        public string TypeBrand { get; set; }
        [Required]
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
        [Required]
        [Display(Name = "Количество")]
        public int Count { get; set; }
    }
}