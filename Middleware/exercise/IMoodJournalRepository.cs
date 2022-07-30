using ADHD.Models.Exercise;

namespace ADHD.Middleware.exercise
{
    public interface IMoodJournalRepository
    {
        Task<MoodJournal> AddMoodJournal(MoodJournal moodJournal);
        Task<List<MoodJournal>> GetMoodJournals();
    }
}
