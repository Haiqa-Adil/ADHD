using ADHD.Models.Disorder;

namespace ADHD.Models
{
    public class SymptomScore
    {
        public Student Student { get; set; }
        public string StudentId { get; set; }
        public Disorder.Disorder Disorder { get; set; }
        public int DisorderId { get; set; }
        public Symptom Symptom { get; set; }
        public int SymptomId { get; set; }
        public string DiagnosedLevel { get; set; }
        public int Score { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
