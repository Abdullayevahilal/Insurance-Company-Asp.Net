using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class FAQ :BaseEntity
    {
       [Required]
       [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Question { get; set; }
        [Required]
        [MaxLength(400)]
        public string Answer { get; set; }
    }

}
