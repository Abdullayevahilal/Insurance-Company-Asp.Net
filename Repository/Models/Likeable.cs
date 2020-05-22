using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public class Likeable :BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string  Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string İmage { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public int AboutUsId { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
