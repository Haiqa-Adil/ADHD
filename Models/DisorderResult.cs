using ADHD.Models.Disorder;

namespace ADHD.Models
{
    public class DisorderResult
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SymptomQuestionId { get; set; }
        public SymptomQuestion SymptomQuestion { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
    }
}
