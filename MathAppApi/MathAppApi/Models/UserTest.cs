using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class UserTest
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public Guid TestId { get; set; }

        public DateTime FinishedOn { get; set; }

        public float Result { get; set; }

        // relationships
        public User User { get; set; }

        public Test Test { get; set; }
    }
}
