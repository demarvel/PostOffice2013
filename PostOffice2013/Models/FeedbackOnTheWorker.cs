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
        public int IdReviews { get; set; }
        public bool ViewReviews { get; set; }
        public string TextReview { get; set; }
        public string AdmResponse { get; set; }
        public int IdWorker { get; set; }
    }
}