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
        public int IdPensiner { get; set; }
        public int PostIndex { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public int SeriesOfPassport { get; set; }
        public int NumberOfPassport { get; set; }
    }
}