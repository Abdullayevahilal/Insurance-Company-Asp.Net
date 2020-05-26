using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.HomeRepository
{
    public interface IHomeRepository
    {
        IEnumerable<HomeSlider> GetFAQs();
        IEnumerable<AboutUs> GetAboutUs();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Agent> GetAgents();
        IEnumerable<Likeable> Likeables();
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<Blog> Blogs();
        IEnumerable<Setting> GetSettings();
        IEnumerable<Product> GetProducts();
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly JotexDbContext _context;
        public HomeRepository(JotexDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Blog> Blogs()
        {
            return _context.Blogs.Where(b => b.Status).ToList();
        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status).ToList();
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(a => a.Status).ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b=> b.AddedDate).ToList();
        }

        public IEnumerable<HomeSlider> GetFAQs()
        {
            return _context.HomeSliders.Where(h => h.Status).OrderBy(h => h.OrderBy).ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.Where(p => p.Status).ToList();
        }

        public IEnumerable<Setting> GetSettings()
        {
            return _context.Settings.Where(s => s.Status).ToList();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(t => t.Status).ToList();
        }

        public IEnumerable<Likeable> Likeables()
        {
            return _context.Likeables.Where(l => l.Status).ToList();
        }
    }
}
