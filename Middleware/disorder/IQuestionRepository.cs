using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IQuestionRepository
    {
        Task<Question> AddQuestion(Question disorder);
        Task<List<Question>> AddQuestionList(List<Question> disorder);  

    }
}
