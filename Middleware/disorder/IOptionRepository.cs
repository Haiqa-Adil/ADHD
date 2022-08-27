using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IOptionRepository
    {
        Task<Option> AddOption(Option option);
        Option GetOptionById(int optionId);
    }
}
