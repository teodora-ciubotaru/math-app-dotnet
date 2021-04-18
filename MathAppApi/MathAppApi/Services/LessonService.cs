using MathAppApi.Data;
using MathAppApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MathAppApi.Services
{
    public class LessonService
    {
        private readonly MathAppDbContext _context;
        private readonly DbSet<Lesson> _set;

        public LessonService(MathAppDbContext context)
        {
            _context = context;
            _set = context.Lessons;
        }

        public List<Lesson> GetAllLessons()
        {
            return _set.ToList();
        }
    }
}
