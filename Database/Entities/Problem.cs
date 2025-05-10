using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Psychologist")]
        public int PsychologistId { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Diagnosis date is required")]
        [DataType(DataType.Date)]
        public DateTime DiagnosisDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Psychologist Psychologist { get; set; }
    }
}
