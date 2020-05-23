using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
   public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }
        public DbSet<Testimonial> Testimonials{ get; set; }
        public DbSet<Agent> Agents { get; set; }
       public DbSet<Brand> Brands { get; set; }
       public DbSet<HomeSlider> HomeSliders { get; set; }
      public DbSet<Label> Labels  { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<ProductSpec> ProductSpecs  { get; set; }
        public DbSet<Setting>Settings { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutSpec> AboutSpecs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Likeable> Likeables { get; set; }
    }

}



