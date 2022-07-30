using ADHD.Models.consultant;

namespace ADHD.Middleware
{
    public interface IConsultantRepository
    {
        Consultant JoinAsConsultant();
        Consultant UpdateConsultant(Consultant consultant);
        List<Consultant> GetConsultants();
        Consultant GetConsultantById(int consultantId);
    }
}
