using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.disorder
{
    public class DisorderRepository : IDisorderRepository
    {
        private DataContext db;
        public DisorderRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<List<Disorder>> GetDisorder()
        {
            var disorder =await db.Disorders.ToListAsync();
            return disorder;
        }

        public async Task<List<SymptomQuestion>> GetQuestion(int synptomId)
        {
            return db.SymptomQuestions.Where(x => x.Symptom.Id == synptomId).ToList();
        }

        public async Task<Disorder> AddDisorder(Disorder disorder)
        {
            await db.Disorders.AddAsync(disorder);
            await db.SaveChangesAsync();
            return disorder;

        }
    }
}
