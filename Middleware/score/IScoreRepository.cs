using ADHD.Models;

namespace ADHD.Middleware.score
{
    public interface IScoreRepository
    {
        Task<DisorderResult> AddScore(List<DisorderResult> disorderResult);
        Task<DisorderResult> UpdateScore(DisorderResult disorderResult);
    }
}