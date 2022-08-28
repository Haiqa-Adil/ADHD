using ADHD.Models.Disorder;

namespace ADHD.Dto.disorder
{
    public class GetQuestionOptionsDto
    {
        public int SymptomQuestionId { get; set; }
        public GetQuestionDto Question { get; set; }
        public List<GetOptionDto> Option { get; set; }
        public GetQuestionOptionsDto() => Option = new List<GetOptionDto>();
    }

    public class GetQuestionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int QuestionType { get; set; }
    }
    public class GetOptionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Marks { get; set; }
    }
}
