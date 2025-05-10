using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [ForeignKey("Problem")]
        public int ProblemId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        [ForeignKey("Psychologist")]
        public int PsychologistId { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        // Navigation properties
        public Problem Problem { get; set; }
        public Psychologist Psychologist { get; set; }
        public User User { get; set; }
    }
}
