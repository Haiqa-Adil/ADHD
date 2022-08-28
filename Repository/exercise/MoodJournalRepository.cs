using ADHD.Data;
using ADHD.Middleware.exercise;
using ADHD.Models.Exercise;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.exercise
{
    public class MoodJournalRepository : IMoodJournalRepository
    {
        private DataContext db;
        public MoodJournalRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<MoodJournal> AddMoodJournal(MoodJournal moodJournal)
        {
            await db.MoodJournals.AddAsync(moodJournal);
            await db.SaveChangesAsync();
            return moodJournal;
        }

        public async Task<List<MoodJournal>> GetMoodJournals()
        {
            return await db.MoodJournals.ToListAsync();
        }
    }
}
 