using ADHD.Models.consultant;

namespace ADHD.Middleware.consultant
{
    public interface IConsultantRepository
    {
        Consultant JoinAsConsultant();
        Consultant UpdateConsultant(Consultant consultant);
        List<Consultant> GetConsultants();
        Consultant GetConsultantById(int consultantId);
    }
}
