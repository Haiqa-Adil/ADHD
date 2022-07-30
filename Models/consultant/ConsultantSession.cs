namespace ADHD.Models.consultant
{
    public class ConsultantSession
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        public string ContactNumber { get; set; }
        public int SessionRate { get; set; }
        public Session Session { get; set; }
        public int SessionId { get; set; }
        public string Address { get; set; }
        public bool IsBooked { get; set; }
    }
}
