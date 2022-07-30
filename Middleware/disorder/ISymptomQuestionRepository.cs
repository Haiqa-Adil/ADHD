using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface ISymptomQuestionRepository
    {
        Task<SymptomQuestion> AddSymptomQuestion(SymptomQuestion symptomQuestion);
        Task<List<Question>> GetSymptomQuestion(int symptomId);
    }
}
