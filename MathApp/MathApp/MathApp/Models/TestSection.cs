using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAppApi.Models
{
    public class TestSection
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public string Solution1 { get; set; }

        public string Solution2 { get; set; }

        public string Solution3 { get; set; }

        public string Solution4 { get; set; }

        public int Answer { get; set; }

        // relationships
        public Test Test { get; set; }

        public Photo Photo { get; set; }
    }
}
