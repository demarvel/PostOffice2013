using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Выплата пенсии
    public class PensionPayment
    {
        [Key]
        [Display (Name = "ID Выплаты")]
        public int IdPayment { get; set; }
        [Display(Name = "Пенсионер")]
        public virtual Pensioner Pensioner { get; set; }
        [Required]
        [Display(Name = "Дата получения")]
        public DateTime DataPayment { get; set; }
        [Required]
        [Display(Name = "Сумма выплаты")]
        public int Payout { get; set; }
        [Display(Name = "Работник")]
        public virtual Worker Worker { get; set; }
    }
}