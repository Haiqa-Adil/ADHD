using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public record Symptom
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int DisorderId {get; init;}
        public Disorder Disorder { get; set; }
        public List<SymptomQuestion> SymptomQuestions { get; set; }
    }
}
