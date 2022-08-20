using ADHD.Models.consultant;

namespace ADHD.Middleware.consultant
{
    public interface IExperienceRepository
    {
        FieldExperience AddExperience(FieldExperience experience);
        FieldExperience UpdateExperience(FieldExperience experience);
    }
}
