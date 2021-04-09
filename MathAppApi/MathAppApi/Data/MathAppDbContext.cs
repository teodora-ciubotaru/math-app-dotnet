using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathAppApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MathAppApi.Data
{
    public class MathAppDbContext : DbContext
    {
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public MathAppDbContext(DbContextOptions<MathAppDbContext> options) : base(options)
        {
            // empty
        }
    }
}
