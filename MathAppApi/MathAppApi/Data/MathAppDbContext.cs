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
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<UserLesson> UserLessons { get; set; }
        public DbSet<LessonSection> LessonSections { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<UserTest> UserTests { get; set; }
        public DbSet<TestSection> TestSections { get; set; }

        public MathAppDbContext(DbContextOptions<MathAppDbContext> options) : base(options)
        {
            // empty
        }
    }
}
