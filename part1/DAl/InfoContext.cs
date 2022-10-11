using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using part1.Model;

namespace part1.DAL
{
    public class InfoContext : DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Info> Infoer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder oBuilder)
        {
            oBuilder.UseLazyLoadingProxies(); //Just in case If we will deside to have more tables for that project
        }
    }
}

