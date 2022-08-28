using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public record Disorder
    {
        public int Id { get; init ; }
        public String Name { get; init; }
        private List<Symptom> symptoms { get; set; }
        public List<Symptom> Symptoms { get { return symptoms; } init { symptoms = value; } }
    }
}
