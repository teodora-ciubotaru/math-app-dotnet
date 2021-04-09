using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class UserLesson
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid LessonId { get; set; }

        public DateTime FinishedOn { get; set; }

        // relationships
        public User User { get; set; }

        public Lesson Lesson { get; set; }
    }
}
