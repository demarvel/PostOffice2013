using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Почтовое отправление
    public class PostItem
    {
        [Key]
        public int IdOperacion { get; set; }
        public int IdWorker { get; set; }
        public string Sender { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public string TypeDeparture { get; set; }
        public int CostOfSending { get; set; }
        public string StatusOfMandate { get; set; }
        public bool CashOnDelivery { get; set; }
        public int PriceCOD { get; set; }
        public bool SentReceived { get; set; }
        public bool FailureObtaining { get; set; }
    }
}