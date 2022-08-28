using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IDisorderRepository
    {
        Task<Disorder> AddDisorder(Disorder disorder);
        Task<List<Disorder>> AddDisorderList(List<Disorder> disorder);
        Task<List<Disorder>> GetDisorder();
    }
}
