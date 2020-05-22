using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Blog :BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string BlogTitle { get; set; }
        [Required]
        [MaxLength(500)]
        public string BlogText { get; set; }
        [Required]
        [MaxLength(100)]
        public string BlogImage { get; set; }
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }
        [Required]
        [MaxLength(100)]
        public string ActionText { get; set; }
       
    }
}
