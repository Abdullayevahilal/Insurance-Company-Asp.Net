using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class Product : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public string Logo { get; set; }
        public int? LabelId { get; set; }
        public Label Label  { get; set; }
    }
}
