using ADHD.Models.consultant;

namespace ADHD.Models.consultant
{
    public enum ConsultantType{
        Consultant,
        Therapist,
        Pshychiatrist,
        Pshychologist
    }
    public class Consultant
    {
        public User User { get; init; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string IdNumber { get; set; }
        public string RegistrationName { get; set; }
        public string RegistrationNumber { get; set; }
        public string RegistrationDocument { get; set; }
        public int RatingCount { get; set; }
        public float Rating { get; set; }
        public int Experience { get; set; }
        public int PatientCount { get; set; }
        public ConsultantType ConsultantType { get; set; }
        public ICollection<FieldExperience> FieldOfExperience { get; set; }
        public ICollection<Qualification> Qualification { get; set; }
        public string ConsultantProfiler { get; set; }
        public string ConsuktantResume { get; set; }
    }
}