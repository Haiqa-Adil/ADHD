using ADHD.Utils;

namespace ADHD.UtilService
{
    public interface IMailService
    {
        bool SendEmail(Message message);
    }
}
