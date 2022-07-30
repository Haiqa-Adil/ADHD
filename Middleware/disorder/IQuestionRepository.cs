using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IQuestionRepository
    {
        Task<Question> AddQuestion(Question disorder);
        
    }
}
