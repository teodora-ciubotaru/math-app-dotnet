using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Grade { get; set; }

    }
}
