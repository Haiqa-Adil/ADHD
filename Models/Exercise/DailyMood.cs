using System;

namespace ADHD.Models.Exercise
{
    public enum Mood
    {
        Worried,
        Happy,
        Normal,
        Sad,
        Angry
    } 
    public record DailyMood
    {
        public int Id { get; init; } 
        public Mood Mood { get; init; }
        public DateTime CreateDate { get; init; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
