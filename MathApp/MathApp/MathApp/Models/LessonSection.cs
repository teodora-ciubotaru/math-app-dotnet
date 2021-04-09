using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class LessonSection
    {
        public Guid Id { get; set; }

        public int Type { get; set; }

        public string Content { get; set; }

        public string Solution { get; set; } // optional

        // relationships
        public Lesson Lesson { get; set; }

        public Photo Photo { get; set; }
    }
}
