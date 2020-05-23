using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IContentRepository
    {
        IEnumerable<HomeSlider> GetHomeSliders();
        IEnumerable<AboutUs> GetAboutUs();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Agent> GetAgents();
        IEnumerable<Likeable> Likeables();
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<Blog> Blogs();
        IEnumerable<Setting> GetSettings();
        IEnumerable<Product> GetProducts();



    }
}
