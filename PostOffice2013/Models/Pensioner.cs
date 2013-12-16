using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Пенсионер
    public class Pensioner
    {
        [Key]
        [Display (Name = "ID Пенсионера")]
        public int IdPensiner { get; set; }
        [Required]
        [Display(Name = "Почтовый индекс")]
        public int PostIndex { get; set; }
        [Required]
        [Display(Name = "Имя пенсионера")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия пенсионера")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Отчество пенсионера")]
        public string Patronymic { get; set; }
        [Required]
        [Display(Name = "Адрес проживания пенсионера")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Серия паспорта")]
        public int SeriesOfPassport { get; set; }
        [Required]
        [Display(Name = "Номер паспорта")]
        public int NumberOfPassport { get; set; }
    }
}