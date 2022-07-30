
namespace ADHD.Models.Exercise
{
    public record MoodJournal
    {
        public int Id { get; init; } 
        public string Text { get; init; }
        public DateTime CreateDate { get; init; }
        public float Anger { get; init; }
        public float Joy { get; init; }
        public float Love { get; init; }
        public float Fear { get; init; }
        public float Sadness { get; init; }
        public float Surprise { get; init; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
