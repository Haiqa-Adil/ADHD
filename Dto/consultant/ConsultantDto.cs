using ADHD.Models.consultant;

namespace ADHD.Dto.consultant
{
    public class ConsultantDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string IdNumber { get; set; }
        public string RegistrationName { get; set; }
        public string RegistrationNumber { get; set; }
        public IFormFile RegistrationDocument { get; set; }
        public int Experience { get; set; }
        public int PatientCount { get; set; }
        public ConsultantType ConsultantType { get; set; }
        public ICollection<FieldExperienceDto> FieldOfExperience { get; set; }
        public ICollection<QualificationDto> Qualification { get; set; }
        public string ConsultantProfiler { get; set; }
        public IFormFile ConsuktantResume { get; set; }

    }
    public class QualificationDto
    {
        public string Description { get; set; }
        public string Institute { get; set; }
    }

    public class FieldExperienceDto
    {
        public string Field { get; set; }
        public int Experience { get; set; }
    }
}
