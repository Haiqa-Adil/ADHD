using ADHD.Data;
using ADHD.Middleware.exercise;
using ADHD.Models.Exercise;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.exercise
{
    public class StoryRepository : IStoryRepository
    {
        private DataContext db;
        public StoryRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<Story> AddStory(Story story)
        {
            await db.Stories.AddAsync(story);
            await db.SaveChangesAsync();
            return story;
        }

        public async Task<List<Story>> GetStories()
        {
            return await db.Stories.ToListAsync();
        }

        public async Task<Story> GetStoryById(int storyId)
        {
            var story = await db.Stories.FirstOrDefaultAsync(x => x.Id == storyId);

            if (story == null)
                throw new Exception();

            return story;
        }
    }
}
