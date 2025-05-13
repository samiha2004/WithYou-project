using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Resetemail
    {
        [Key]
        [Required(ErrorMessage = "يرجى إدخال البريد الإلكتروني")]
        [EmailAddress(ErrorMessage = "صيغة البريد الإلكتروني غير صحيحة")]
        public string Email { get; set; }
    }
}
