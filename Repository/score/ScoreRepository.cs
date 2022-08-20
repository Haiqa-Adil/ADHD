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
        public async Task<DisorderResult> AddScore(List<DisorderResult> disorderResult)
        {
            await db.DisorderResults.AddRangeAsync();
            await db.SaveChangesAsync();
            return disorderResult[0];
        }

        public Task<DisorderResult> UpdateScore(DisorderResult disorderResult)
        {
            throw new NotImplementedException();
        }
    }
}
