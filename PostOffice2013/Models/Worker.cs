using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Работник почтового отделения
    public class Worker
    {
        [Key]
        [Display(Name = "ID Работника")]
        public int IdWorker { get; set; }
        [Required]
        [Display(Name = "Имя работника")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия работника")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Отчество работника")]
        public string Patronymic { get; set; }
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
        [Required]
        [Display(Name = "Почтовый индекс")]
        public int PostIndex { get; set; }
    }
}