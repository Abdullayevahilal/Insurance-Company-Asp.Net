using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AboutSpec : BaseEntity

    {
        public string Logo { get; set; }
        [MaxLength(50)]
        public string Key { get; set; }
        [MaxLength(500)]
        public string Value { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
        
    }
}
