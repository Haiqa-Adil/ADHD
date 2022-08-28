using ADHD.Models.Disorder;

namespace ADHD.Middleware.disorder
{
    public interface IOptionRepository
    {
        Task<Option> AddOption(Option option);
        Task<List<Option>> AddOptionList(List<Option> option);
        Option GetOptionById(int optionId);
    }
}
