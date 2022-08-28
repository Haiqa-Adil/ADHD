using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public record Option
    {
        public int Id { get; init; }
        public string Description { get; init; }
        public int Marks { get; init; }
        public List<QuestionOption> QuestionOptions { get; set; }
    }
}
