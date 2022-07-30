using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Teacher
{
    public record Teacher
    {
        public User User { get; init; }
        public int Id { get; init; }
        public string NIC { get; init; }
        public string School { get; init; }
        public string Place { get; init; }
        public string City { get; init; }
        public string Province { get; init; }
    }
}
