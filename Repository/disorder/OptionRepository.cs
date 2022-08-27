using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository.disorder
{
    public class OptionRepository : IOptionRepository
    {
        DataContext db;
        public OptionRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<Option> AddOption(Option option)
        {
            await db.Options.AddAsync(option);
            await db.SaveChangesAsync();
            return option;
        }

        public Option GetOptionById(int optionId)
        {
            var option = db.Options.FirstOrDefault(x => x.Id == optionId);
            return option!;
        }
    }
}
