using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models
{
    public class Student
    {
        public Guid GuidId { get; init; } = Guid.NewGuid();
        public string Name { get; init; }
        public int Age { get; init; }
        public Gender Gender { get; init; }
        public User User { get; init; }
        public int UserId { get; set; }
    }
}
