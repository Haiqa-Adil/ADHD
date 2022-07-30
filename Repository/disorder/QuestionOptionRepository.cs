using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.disorder
{
    public class QuestionOptionRepository : IQuestionOptionRepository
    {
        DataContext db;
        public QuestionOptionRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<QuestionOption> AddQuestionOption(QuestionOption option)
        {
            await db.QuestionOption.AddAsync(option);
            await db.SaveChangesAsync();
            return option;
        }

        public async Task<List<Option>> GetQuestionOption(int questionId)
        {
            return await db.QuestionOption
                .Where(x => x.Question.Id == questionId)
                .Select(x => x.Option).ToListAsync();
        }
    }
}
