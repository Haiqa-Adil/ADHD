using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.disorder
{
    public class SymptomRepository : ISymptomRepository
    {
        DataContext db;
        public SymptomRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<Symptom> AddSymptom(Symptom symptom)
        {
            await db.Symptoms.AddAsync(symptom);
            await db.SaveChangesAsync();
            return symptom;
        }

        public async Task<List<Symptom>> GetSymptom(int disorderId)
        {
            var symptom = await db.Symptoms.Where(x => x.Disorder.Id == disorderId).ToListAsync();
            return symptom;
        }
    }
}
