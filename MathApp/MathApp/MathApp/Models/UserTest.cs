using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class UserTest
    {
        public Guid Id { get; set; }

        public DateTime FinishedOn { get; set; }

        public float Result { get; set; }

        // relationships
        public User User { get; set; }

        public Test Test { get; set; }
    }
}
