using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Session")]
        public int SessionId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, 10000, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Method { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Session Session { get; set; }
    }
}
