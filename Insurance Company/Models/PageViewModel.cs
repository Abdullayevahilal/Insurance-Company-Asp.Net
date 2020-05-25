using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance_Company.Models
{
    public class PageViewModel
    {
        public IEnumerable<FAQ> FAQs { get; set; }
    }
}
