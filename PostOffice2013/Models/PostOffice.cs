using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Почтовое отделение
    public class PostOffice
    {
        [Key]
        [Display (Name = "Почтовый индекс")]
        public int PostIndex { get; set; }
        [Required]
        [Display (Name = "Адрес почтового отделения")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Контактый телефон")]
        public string ContactPhone { get; set; }
        [Required]
        [Display(Name = "Часы работы почтового отделения")]
        public string OpeningHours { get; set; }
        [Display(Name = "Пенсионеры почтового отделения")]
        public virtual ICollection<Pensioner> Pensioners { get; set; }
        [Display(Name = "Работники почтового отделения")]
        public virtual ICollection<Worker> Workers { get; set; }
    }
}