﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Продажа товара
    public class SaleOfGoods
    {
        [Key]
        [Display (Name = "ID Покупки")]
        public int IdPurchase { get; set; }
        [Required]
        [Display(Name = "Время покупки")]
        public DateTime TimeOfPurchase { get; set; }
        [Required]
        [Display(Name = "Итоговая цена")]
        public int TotalPrice { get; set; }
        [Required]
        [Display(Name = "Количество купленного товара")]
        public int NumberOfPurchasedGoods { get; set; }
        [Display(Name = "Работник")]
        public virtual Worker Worker { get; set; }
        [Display(Name = "Количество операций с проданными упаковками")]
        public virtual ICollection<Packing> Packings { get; set; }
        [Display(Name = "Количество операций с проданными марками")]
        public virtual ICollection<Brand> Brands { get; set; }
    }
}