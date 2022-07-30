using ADHD.Models.Exercise;

namespace ADHD.Middleware.exercise
{
    public interface IDailyMoodRepository
    {
        Task<DailyMood> AddMood(DailyMood mood);
        Task<List<DailyMood>> GetMoodList();
    }
}
