using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public record SymptomQuestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int SymptomId { get; set; }
        public Symptom Symptom { get; init; }
        public Question Question { get; init; }
    }
}
