using ADHD.Data;
using ADHD.Middleware.score;
using ADHD.Models;

namespace ADHD.Repository.score
{
    public class ScoreRepository : IScoreRepository
    {
        private DataContext db;
        public ScoreRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<SymptomScore> AddDisorderScore(SymptomScore score)
        {
            await db.SymptomScores.AddAsync(score);
            await db.SaveChangesAsync();
            return score;
        }

        public async Task<List<DisorderResult>> AddScore(List<DisorderResult> disorderResult)
        {
            await db.DisorderResults.AddRangeAsync();
            await db.SaveChangesAsync();
            return disorderResult;
        }

        public Task<SymptomScore> GetSymptomScore(DisorderResult disorderResult)
        {
            throw new NotImplementedException();
        }

        public Task<DisorderResult> UpdateScore(DisorderResult disorderResult)
        {
            throw new NotImplementedException();
        }
    }
}
