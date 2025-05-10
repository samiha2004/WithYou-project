using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithYou_project.Database.Entities
{
    public class Psychologist
    {
        [Key]
        public int PsychologistId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password and confirmation password do not match.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string Certificates { get; set; }

        public string Specialization { get; set; }

        [Range(0, 50, ErrorMessage = "Experience years must be between 0 and 50")]
        public int ExperienceYears { get; set; }

        //Navigation
        public ICollection<Session> Sessions { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Problem> Problems { get; set; }
        public ICollection<Message> Messages { get; set; }


    }
}
