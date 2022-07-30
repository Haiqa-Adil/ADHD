using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;

namespace ADHD.Repository.disorder
{
    public class QuestionRepository : IQuestionRepository
    {
        private DataContext db;
        public QuestionRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<Question> AddQuestion(Question question)
        {
            await db.Questions.AddAsync(question);
            await db.SaveChangesAsync();
            return question;
        }
    }
}
