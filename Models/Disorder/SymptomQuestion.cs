using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public record SymptomQuestion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int SymptomId { get; set; }
        public Symptom Symptom { get; init; }
        public Question Question { get; init; }
    }
}
