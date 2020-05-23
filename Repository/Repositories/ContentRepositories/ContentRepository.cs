using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{

    class ContentRepository : IContentRepository
    {
        private readonly JotexDbContext _context;
        public ContentRepository(JotexDbContext context)
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
            return _context.Brands.Where(b => b.Status).ToList();
        }

        public IEnumerable<HomeSlider> GetHomeSliders()
        {
            return _context.HomeSliders.Where(h => h.Status).OrderBy(h => h.OrderBy).ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setting> GetSettings()
        {
            throw new NotImplementedException();
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
  
    
