using ADHD.Models.consultant;

namespace ADHD.Middleware
{
    public interface IConsultantSessionRepository
    {
        List<ConsultantSession> GetConsultantSession(int consultantId);
        ConsultantRating RemoveSession(int id);
        List<ConsultantRating> AddConsultantSession(List<ConsultantRating> consultantRating);

    }
}
