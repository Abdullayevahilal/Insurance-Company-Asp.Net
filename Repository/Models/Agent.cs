using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
  public class Agent :BaseEntity
    {      
        public string Name { get; set; }
        public string Image { get; set; }
        public int Phone { get; set; }
        public int ProductId { get; set; }
        public string Experience { get; set; }
        public Product Product { get; set; }
    }
}
