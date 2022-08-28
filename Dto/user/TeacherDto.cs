namespace ADHD.Dto.user
{
    public class TeacherDto
    {
        public string NIC { get; init; }
        public string School { get; init; }
        public string Place { get; init; }
        public string City { get; init; }
        public string Province { get; init; }
        public List<int> Classes { get; init; }
    }
}
