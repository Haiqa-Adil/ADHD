using ADHD.Data;
using ADHD.Middleware.exercise;
using ADHD.Models.Exercise;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.exercise
{
    public class DailyMoodRepository : IDailyMoodRepository
    {
        private DataContext db;
        public DailyMoodRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<DailyMood> AddMood(DailyMood mood)
        {
            await db.DailyMoods.AddAsync(mood);
            await db.SaveChangesAsync();
            return mood;
        }

        public async Task<List<DailyMood>> GetMoodList()
        {
            return await db.DailyMoods.ToListAsync();
        }
    }
}
