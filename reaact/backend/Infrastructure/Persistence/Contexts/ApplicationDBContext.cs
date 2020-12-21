using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
          
           
        }
        public DbSet<Article> Articles { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
           
            base.OnModelCreating(builder);
        }
    }
}
