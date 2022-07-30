using ADHD.Models.Disorder;

namespace ADHD.Dto.disorder
{
    public class GetQuestionOptionsDto
    {
        public Question Question { get; set; }
        public List<Option> Option { get; set; }
        public GetQuestionOptionsDto() => Option = new List<Option>();
    }
}
