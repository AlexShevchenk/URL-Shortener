using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Models;
using URLShortener.Models;

namespace URLShortener.Data
{
    public class AppDbContext : IdentityDbContext <AppUser>
    {
        public DbSet<ShortUrl> ShortUrls { get; set; }
        public DbSet<AboutContent> AboutContents { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ShortUrl>()
                .HasIndex(u => u.ShortCode)
                .IsUnique();
        }
    }
}