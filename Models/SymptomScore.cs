using ADHD.Models.Disorder;

namespace ADHD.Models
{
    public class SymptomScore
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Disorder.Disorder Disorder { get; set; }
        public int DisorderId { get; set; }
        public Symptom Symptom { get; set; }
        public int SymptomId { get; set; }
        public int NoOfSymptomDetect { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
