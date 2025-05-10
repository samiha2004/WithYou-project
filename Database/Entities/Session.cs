using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithYou_project.Database.Entities
{
    public class Session
    {

        [Key]
        public int SessionId { get; set; }

        [Required]
        [ForeignKey("Psychologist")]
        public int PsychologistId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required")]
        public string Time { get; set; }


        // Navigation properties
        public Psychologist Psychologist { get; set; }
  
        public User User { get; set; }
    }
}
