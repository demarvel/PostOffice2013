﻿using System;
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
        [Display(Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Display(Name = "Заказное")]
        public bool Registered { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
    }
}