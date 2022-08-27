using ADHD.Models;

namespace ADHD.Middleware.score
{
    public interface IScoreRepository
    {
        Task<List<DisorderResult>> AddScore(List<DisorderResult> disorderResult);
        Task<SymptomScore> AddDisorderScore(SymptomScore score);
        Task<DisorderResult> UpdateScore(DisorderResult disorderResult);
        Task<SymptomScore> GetSymptomScore(DisorderResult disorderResult);
    }
}