using ADHD.Models.Disorder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADHD.Models
{
    public class DisorderResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public SymptomQuestion SymptomQuestion { get; set; }
        public int SymptomQuestionId { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
    }
}
