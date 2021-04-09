using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathAppApi.Data;
using MathAppApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MathAppApi.Services
{
    public class UserService
    {
        private readonly MathAppDbContext _context;
        private readonly DbSet<User> _set;

        public UserService(MathAppDbContext context)
        {
            _context = context;
            _set = context.Users;
        }

        public List<User> GetAllUsers()
        {
            return _set.ToList();
        }
    }
}
