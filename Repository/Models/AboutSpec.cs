using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AboutSpec : BaseEntity

    {
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
       [Required]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required]
        [MaxLength(500)]
        public string Value { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
        
    }
}
