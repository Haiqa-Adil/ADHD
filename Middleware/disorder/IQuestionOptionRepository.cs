using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IQuestionOptionRepository
    {
        Task<QuestionOption> AddQuestionOption(QuestionOption option);
        Task<List<Option>> GetQuestionOption(int questionId);
    }
}
