using ADHD.Models.consultant;

namespace ADHD.Middleware
{
    public interface IRatingRepository
    {
        List<ConsultantRating> GetRatings();
        List<ConsultantRating> GetRatings(int consultantId);
        ConsultantRating AddConsultantRating(ConsultantRating consultantRating);
    }
}
