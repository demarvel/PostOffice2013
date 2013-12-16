using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Пользователь
    public class User
    {
        [Key]
        [Display(Name="ID Пользователя")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "e-mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Дата регистрации")]
        public DateTime DateRegister { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Отчество")]
        public string SecondName { get; set; }
        [Required]
        [Display(Name = "Адрес прописки")]
        public string Adrress { get; set; }
        [Required]
        [Display(Name = "Почтовый индекс")]
        public int PostIndex { get; set; }
    }
    //Работник
    public class Worker : User
    {
        [Required]
        [Display(Name = "Стаж работы")]
        public int LengthOfWork { get; set; }
        [Required]
        [Display(Name = "Дата принятия на работу")]
        public DateTime DateOfEmployment { get; set; }
        [Required]
        [Display(Name = "Заработная плата")]
        public int Wages { get; set; }
        [Required]
        [Display(Name = "Должность")]
        public string Post { get; set; }
        [Display(Name = "Почтовое отделение")]
        public virtual PostOffice PostOffice { get; set; }
        [Display(Name = "Почтовые отправления")]
        public virtual ICollection<PostItem> PostItems { get; set; }
        [Display(Name = "Продажи товаров")]
        public virtual ICollection<SaleOfGoods> SaleOfGoods { get; set; }
        [Display(Name = "Отзывы о сотруднике")]
        public virtual ICollection<FeedbackOnTheWorker> FeedbackOnWorkers { get; set; }
    }
    //Пенсионер
    public class Pensioner : User
    {
        [Required]
        [Display(Name = "Серия паспорта")]
        public int SeriesOfPassport { get; set; }
        [Required]
        [Display(Name = "Номер паспорта")]
        public int NumberOfPassport { get; set; }
        [Display(Name = "Почтовое отделение")]
        public virtual PostOffice PostOffice { get; set;}
        [Display(Name = "Пенсионные выплаты")]
        public virtual ICollection<PensionPayment> PensionPayments { get; set; }
    }
    //Администратор
    public class Administrator : User
    {
        [Required]
        [Display(Name = "Дата последнего визита")]
        public DateTime DateOfLastEntry { get;set; }
    }

}