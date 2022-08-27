namespace ADHD.Dto.disorder
{
    public class SymptomDto
    {
        public string Name { get; set; }
        public int DisorderId { get; set; }
    }
    public class GetSymptomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisorderId { get; set; }
    }
}
