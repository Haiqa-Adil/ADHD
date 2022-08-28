namespace ADHD.Dto.exercise
{
    public class MoodJournalDto
    {
        public int UserId { get; set; }
        public string Text { get; set; }
        public float Anger { get; init; }
        public float Joy { get; init; }
        public float Love { get; init; }
        public float Fear { get; init; }
        public float Sadness { get; init; }
        public float Surprise { get; init; }
    }
}
