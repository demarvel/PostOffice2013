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
        [Display(Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Required]
        [Display(Name = "Дата извещения")]
        public DateTime DateOfNotification { get; set; }
        [Display(Name = "Повторное отправление")]
        public bool SecondNotice { get; set; }
    }
}