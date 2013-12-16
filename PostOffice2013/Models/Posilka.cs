using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PostOffice2013.Models
{
    //Посылка
    public class Posilka
    {
        [Key]
        [Display(Name = "ID Операции")]
        public int IdOperacion { get; set; }
        [Required]
        [Display(Name = "Объявленная ценность")]
        public int DeclaredValue { get; set; }
        [Required]
        [Display(Name = "Вес")]
        public string Weight { get; set; }
        [Required]
        [Display(Name = "Ширина")]
        public int Width { get; set; }
        [Required]
        [Display(Name = "Длина")]
        public int Length { get; set; }
        [Required]
        [Display(Name = "Высота")]
        public int height { get; set; }
    }
}