using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Отзыв о работнике
    public class FeedbackOnTheWorker
    {
        [Key]
        [Display(Name = "ID Отзыва")]
        public int IdReviews { get; set; }
        [Required]
        [Display(Name = "Вид отзыва")]
        public bool ViewReviews { get; set; }
        [Required]
        [Display(Name = "Текст отзыва")]
        public string TextReview { get; set; }
        [Required]
        [Display(Name = "Ответ администрации")]
        public string AdmResponse { get; set; }
        [Required]
        [Display(Name = "ID Работника")]
        public int IdWorker { get; set; }
    }
}