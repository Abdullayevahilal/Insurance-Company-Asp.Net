using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
 public class AboutUs :BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string AboutTitle { get; set; }
        [Required]
        [MaxLength(500)]
        public string AboutText { get; set; }
        [Required]
        [MaxLength(50)]
        public string AboutPhone { get; set; }
        [Required]
        [MaxLength(100)]
        public string İmage { get; set; }
        public ICollection<AboutSpec> AboutSpecs { get; set; }
        public ICollection<Likeable> Likeables { get; set; }


    }
}
