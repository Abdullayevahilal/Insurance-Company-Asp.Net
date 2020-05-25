using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Comment :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Website { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
