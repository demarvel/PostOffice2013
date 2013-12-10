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
        public int PostIndex { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public string OpeningHours { get; set; }
    }
    //Пенсионер
    public class Pensioner
    {
        [Key]
        public int IdPensiner { get; set; }
        public int PostIndex { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public int SeriesOfPassport { get; set; }
        public int NumberOfPassport { get; set; }
    }
    //Работник почтового отделения
    public class Worker
    {
        [Key]
        public int IdWorker { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int LengthOfWork { get; set; }
        public DateTime? DateOfEmployment { get; set; }
        public string Wages { get; set; }
        public string Post { get; set; }
        public int PostIndex { get; set; }
    }
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
    //Отзыв о работнике
    public class FeedbackOnTheWorker
    {

    }
    //Почтовое отправление
    public class PostalItem
    {

    }
    //Продажа товара
    public class SaleOfGoods
    {

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