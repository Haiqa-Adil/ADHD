using ADHD.Models;
using ADHD.Models.booking;
using ADHD.Models.consultant;
using ADHD.Models.Disorder;
using ADHD.Models.Exercise;
using ADHD.Models.Teacher;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Data
{
    public class DataContext: IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Disorder> Disorders { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<SymptomQuestion> SymptomQuestions { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<MoodJournal> MoodJournals { get; set; }
        public DbSet<DailyMood> DailyMoods { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<ConsultantSession> ConsultantSession { get; set; }
        public DbSet<FieldExperience> ExperienceInField { get; set; }
        public DbSet<Qualification> FieldOfStudy { get; set; }
        public DbSet<ConsultantRating> Ratings { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingReschedule> BookingReschedules { get; set; }
        public DbSet<BookingSession> BookingSessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DisorderResult> DisorderResults { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SymptomScore> SymptomScores { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<QuestionOption>()
                .HasKey(x => new { x.QuestionId ,x.OptionId });
            builder.Entity<SymptomQuestion>()
                .HasKey(x => new {x.QuestionId, x.SymptomId });
            builder.Entity<SymptomQuestion>()
                .HasIndex(x => x.Id)
                .IsUnique();
            builder.Entity<BookingSession>()
                    .HasKey(x => new { x.BookingId, x.SessionId });
            builder.Entity<DisorderResult>()
                    .HasKey(x => new { x.StudentId, x.SymptomQuestionId });
            builder.Entity<Student>()
                    .HasKey(x => new { x.UserId, x.GuidId });
            builder.Entity<SymptomScore>()
                    .HasKey(x => new { x.StudentId, x.SymptomId });
        }
    }
}
