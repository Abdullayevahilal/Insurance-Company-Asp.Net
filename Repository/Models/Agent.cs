using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public class Agent :BaseEntity
    {      
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public int Phone { get; set; }
        public int ProductId { get; set; }
        [Required]
        public string Experience { get; set; }
        public Product Product { get; set; }
    }
}
