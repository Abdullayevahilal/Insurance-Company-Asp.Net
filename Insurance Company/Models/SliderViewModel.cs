using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance_Company.Models
{
    public class SliderViewModel
    {
        public string Title { get; set; }

        public string Slogon { get; set; }

        public string Image { get; set; }

        public string ActionText { get; set; }

        public string EndPoint { get; set; }
    }
}
