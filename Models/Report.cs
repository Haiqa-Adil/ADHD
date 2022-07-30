namespace ADHD.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string ReportId { get; set; }
        public int Score { get; set; }
        public int DiagnosedLevel { get; set; }
        public DateOnly LastUpdate { get; set; }
    }
}
