using System.ComponentModel.DataAnnotations.Schema;

namespace ADHD.Models.consultant
{
    [Table("Rating")]
    public class ConsultantRating
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Consultant Consultant { get; set; }
        public float Rating { get; set; }
    }
}
