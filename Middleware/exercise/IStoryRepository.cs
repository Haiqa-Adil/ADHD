using ADHD.Models.Exercise;

namespace ADHD.Middleware.exercise
{
    public interface IStoryRepository
    {
        Task<List<Story>> GetStories();
        Task<Story> GetStoryById(int storyId);
        Task<Story> AddStory(Story story);
    }
}
