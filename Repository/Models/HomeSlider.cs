﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class HomeSlider :BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(400)]
        public string Slogon { get; set; }
        [Required]
        [MaxLength(50)]
        public string  ActionText { get; set; }



    }
}
