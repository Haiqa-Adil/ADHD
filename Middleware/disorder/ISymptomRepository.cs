using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface ISymptomRepository
    {
        Task<Symptom> AddSymptom(Symptom symptom);
        Task<List<Symptom>> GetSymptom(int disorderId);
    }
}
