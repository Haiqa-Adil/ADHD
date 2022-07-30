using ADHD.Models.consultant;

namespace ADHD.Middleware
{
    public interface IQualificationRepository
    {
        Qualification AddQualification(Qualification qualification);
    }
}
