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
        public int IdPayment { get; set; }
        public int IdPensiner { get; set; }
        public DateTime? DataPayment { get; set; }
        public int Payout { get; set; }
        public int IdWorker { get; set; }
    }
}