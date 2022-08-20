using ADHD.Models.consultant;

namespace ADHD.Middleware.consultant
{
    public interface IQualificationRepository
    {
        Qualification AddQualification(Qualification qualification);
    }
}
