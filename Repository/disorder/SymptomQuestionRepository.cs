using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.disorder
{
    public class SymptomQuestionRepository : ISymptomQuestionRepository
    {
        DataContext db;
        public SymptomQuestionRepository(DataContext db)
        {
            this.db = db;
        }
        public async Task<SymptomQuestion> AddSymptomQuestion(SymptomQuestion symptomQuestion)
        {
            await db.SymptomQuestions.AddAsync(symptomQuestion);
            await db.SaveChangesAsync();
            return symptomQuestion;
        }

        public async Task<List<Question>> GetSymptomQuestion(int symptomId)
        {
            return await db.SymptomQuestions
                .Where(x => x.Symptom.Id == symptomId)
                .Select(x => x.Question).ToListAsync();
        }
    }
}
