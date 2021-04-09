using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class LessonSection
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid LessonId { get; set; }

        public Guid PhotoId { get; set; }

        public int Type { get; set; }

        public string Content { get; set; }

        public string Solution { get; set; } // optional

        // relationships
        public Lesson Lesson { get; set; }

        public Photo Photo { get; set; }
    }
}
