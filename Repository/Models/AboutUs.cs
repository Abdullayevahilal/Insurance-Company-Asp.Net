using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class AboutUs : BaseEntity
    {
        public string Name { get; set; }
        public string AboutText { get; set; }
        public string Position { get; set; }
    }
}
