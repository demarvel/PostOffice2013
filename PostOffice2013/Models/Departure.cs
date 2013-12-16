using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Извещение
    public class Notice
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
        [Required]
        [Display(Name = "Дата извещения")]
        public DateTime DateOfNotification { get; set; }
        [Display(Name = "Повторное отправление")]
        public bool SecondNotice { get; set; }
    }
    //Мешок "М"
    public class BagM : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
    }
    //Бандероль
    public class Banderoll : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Required]
        [Display(Name = "Ширина")]
        public int Width { get; set; }
        [Required]
        [Display(Name = "Длина")]
        public int Length { get; set; }
        [Required]
        [Display(Name = "Высота")]
        public int height { get; set; }
    }
    //Письмо
    public class Letter : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Display(Name = "Первый класс")]
        public bool FirstClass { get; set; }
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
    }
    //Посылка
    public class Posilka : PostItem
    {
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Required]
        [Display(Name = "Ширина")]
        public int Width { get; set; }
        [Required]
        [Display(Name = "Длина")]
        public int Length { get; set; }
        [Required]
        [Display(Name = "Высота")]
        public int height { get; set; }
    }
    //Почтовый контейнер
    public class PostalContainer :PostItem
    {
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Required]
        [Display(Name = "Ширина")]
        public int Width { get; set; }
        [Required]
        [Display(Name = "Длина")]
        public int Length { get; set; }
        [Required]
        [Display(Name = "Высота")]
        public int height { get; set; }
    }
    //Почтовая карточка
    public class PostCard : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Display(Name = "Текст сообщения")]
        public string Message { get; set; }
        [Display(Name = "Платеж")]
        public int Payment { get; set; }
    }
    //Секограмма
    public class Secogramma : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
    }
    //Мелкий пакет
    public class SmallPacket : PostItem
    {
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Required]
        [Display(Name = "Платеж")]
        public int Payment { get; set; }
    }
}