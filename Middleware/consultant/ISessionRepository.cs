using ADHD.Models.consultant;

namespace ADHD.Middleware.consultant
{
    public interface ISessionRepository
    {
        List<Session> GetSessions();
        Session CreateSession(Session session);
    }
}
