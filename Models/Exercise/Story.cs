
namespace ADHD.Models.Exercise
{
    public record Story
    {
        public int Id { get; init; } 
        public string Title { get; init; }
        public string Text { get; init; }
        public DateTime CreateDate { get; init; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
