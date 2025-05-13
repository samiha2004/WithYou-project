namespace WithYou_project.Database.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
        public int? YearsExperience { get; set; }
        public string ProfileImage { get; set; }
        public string CertificatesFile { get; set; }
        public string AccountType { get; set; }
    }
}

