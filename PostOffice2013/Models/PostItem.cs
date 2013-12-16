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
        [Display (Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Display(Name = "Работник")]
        public virtual Worker Worker { get; set; }
        [Required]
        [Display(Name = "Отправитель")]
        public string Sender { get; set; }
        [Required]
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }
        [Required]
        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }
        [Required]
        [Display(Name = "Тип отправления")]
        public string TypeDeparture { get; set; }
        [Required]
        [Display(Name = "Стоимость отправления")]
        public int CostOfSending { get; set; }
        [Required]
        [Display(Name = "Статус почтового отправления")]
        public string StatusOfMandate { get; set; }
        [Required]
        [Display(Name = "Наложенный платеж")]
        public bool CashOnDelivery { get; set; }
        [Required]
        [Display(Name = "Цена наложенного платежа")]
        public int PriceCOD { get; set; }
        [Display(Name = "Получение/Отправление")]
        public bool SentReceived { get; set; }
        [Display(Name = "Отказ получения")]
        public bool FailureObtaining { get; set; }
        [Display(Name = "Количество отправлений Мешок М")]
        public virtual ICollection<BagM> BagMs {get;set;}
        [Display(Name = "Количество отправлений Бандеролей")]
        public virtual ICollection<Banderoll> Banderolls {get;set;}
        [Display(Name = "Количество отправлений Писем")]
        public virtual ICollection<Letter> Letters {get;set;}
        [Display(Name = "Количество отправлений Извещений")]
        public virtual ICollection<Notice> Notices {get;set;}
        [Display(Name = "Количество отправлений Посылок")]
        public virtual ICollection<Posilka> Posilkas {get;set;}
        [Display(Name = "Количество отправлений Почтовых контейнеров")]
        public virtual ICollection<PostalContainer> PostalContainers {get;set;}
        [Display(Name = "Количество отправлений Почтовых карт")]
        public virtual ICollection<PostCard> PostCards {get;set;}
        [Display(Name = "Количество отправлений Секограмм")]
        public virtual ICollection<Secogramma> Secogrammas {get;set;}
        [Display(Name = "Количество отправлений Мелких пакотов")]
        public virtual ICollection<SmallPacket> SmallPackets { get; set; }
    }
}