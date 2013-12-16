using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Письмо
    public class Letter
    {
        [Key]
        [Display(Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Display(Name="Заказное")]
        public bool Registered { get; set; }
        [Display(Name="Первый класс")]
        public bool FirstClass { get; set; }
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
    }
}