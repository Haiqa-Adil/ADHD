using ADHD.Models.consultant;
using ADHD.Middleware;
using ADHD.Data;

namespace ADHD.Repository.consultant
{
    public class ConsultantRepository : IConsultantRepository
    {
        private DataContext db;
        public ConsultantRepository(DataContext db)
        {
            this.db = db;
        }

        
        public Consultant GetConsultantById(int consultantId)
        {
            throw new NotImplementedException();
        }

        public List<Consultant> GetConsultants()
        {
            var user = db.Consultants.ToList();
            return user;
        }

        public Consultant JoinAsConsultant()
        {
            throw new NotImplementedException();
        }

        public Consultant UpdateConsultant(Consultant consultant)
        {
            throw new NotImplementedException();
        }
    }
}
