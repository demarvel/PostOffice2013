using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Мешок "М"
    public class BagM
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
    }
    //Бандероль
    public class Banderoll
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
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
    public class Letter
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Display(Name = "Первый класс")]
        public bool FirstClass { get; set; }
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
    }
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
    //Посылка
    public class Posilka
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
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
    public class PostalContainer
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
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
    public class PostCard
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Display(Name = "Текст сообщения")]
        public string Message { get; set; }
        [Display(Name = "Платеж")]
        public int Payment { get; set; }
    }
    //Секограмма
    public class Secogramma
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
    }
    //Мелкий пакет
    public class SmallPacket
    {
        [Key]
        [Display(Name = "Почтовое отправление")]
        public virtual PostItem PostItem { get; set; }
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