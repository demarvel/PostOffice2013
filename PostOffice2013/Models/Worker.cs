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
}