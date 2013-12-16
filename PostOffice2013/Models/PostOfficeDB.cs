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
    }
    //Упаковка
    public class Packing
    {

    }
    //Марка
    public class Brand
    {

    }
    //Извещение
    public class Notice
    {

    }
    //Почтовая карточка
    public class PostCard
    {

    }
    //Мелкий пакет
    public class SmallPacket
    {

    }
    //Письмо
    public class Letter
    {

    }
    //Почтовый контейнер
    public class PostalContainer
    {

    }
    //Секограмма
    public class Secogramma
    {

    }
    //Бандероль
    public class Banderoll
    {

    }
    //Посылка
    public class Posilka
    {

    }
    //Мешок "М"
    public class BagM
    {

    }
}