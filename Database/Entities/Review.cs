using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithYou_project.Database.Entities
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Psychologist")]
        public int PsychologistId { get; set; }

        public string Comment { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }


        // Navigation properties
        public User User { get; set; }
        public Psychologist Psychologist { get; set; }

    }
}
