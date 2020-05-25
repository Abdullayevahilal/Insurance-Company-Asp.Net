using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.PageRepository
{
    public interface IPageRepository
    {
        Setting GetSettings();
        IEnumerable<FAQ> GetFAQs();
    }
    public class PageRepository : IPageRepository
    {
        private readonly JotexDbContext _context;
        public PageRepository(JotexDbContext context)
        {
            _context = context;

        }

        public IEnumerable<FAQ> GetFAQs()
        {
            return _context.FAQs.Where(f => f.Status)
                            .OrderByDescending(f => f.AddedDate)
                            .ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }
    }
}
     