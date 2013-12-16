using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Почтовая карточка
    public class PostCard
    {
        [Key]
        [Display(Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Display(Name="Заказное")]
        public bool Registered { get; set; }
        [Display(Name = "Текст сообщения")]
        public string Message { get; set; }
        [Display(Name = "Платеж")]
        public int Payment { get; set; }
    }
}