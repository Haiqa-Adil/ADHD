namespace ADHD.Dto.consultant
{
    public class ConsultantSessionDto
    {
        public int ConsultantId { get; set; }
        public string ContactNumber { get; set; }
        public int SessionRate { get; set; }
        public List<int> SessionId { get; set; }
        public string Address { get; set; }
    }
}
