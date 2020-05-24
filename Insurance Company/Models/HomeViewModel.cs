using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance_Company.Models
{
    public class HomeViewModel
    {
        public IEnumerable<AboutUs> AboutUs { get; set; }
        public IEnumerable<Agent> Agents { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Likeable> Likeables { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<HomeSlider> HomeSliders { get; set; }


    }
}
