using System;
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
        public int IdPurchase { get; set; }
        public DateTime? TimeOfPurchase { get; set; }
        public int TotalPrice { get; set; }
        public int NumberOfPurchasedGoods { get; set; }
    }
}