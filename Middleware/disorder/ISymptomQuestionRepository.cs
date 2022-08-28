using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface ISymptomQuestionRepository
    {
        Task<SymptomQuestion> AddSymptomQuestion(SymptomQuestion symptomQuestion);
        Task<List<SymptomQuestion>> AddSymptomQuestionList(List<SymptomQuestion> symptomQuestion);
        Task<List<SymptomQuestion>> GetSymptomQuestion(int symptomId);
        Task<Symptom> FindSymptomQuestion(int id);
    }
}
