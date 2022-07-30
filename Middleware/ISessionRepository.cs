using ADHD.Models.consultant;

namespace ADHD.Middleware
{
    public interface ISessionRepository
    {
        List<Session> GetSessions();
        Session CreateSession(Session session);
    }
}
