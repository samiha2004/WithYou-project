using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Resetpassword
    {
 
      
            [Required]
        [EmailAddress(ErrorMessage = "صيغة البريد الإلكتروني غير صحيحة")]
        [StringLength(100, ErrorMessage = "البريد الإلكتروني يجب أن يكون أقل من 100 حرف")]
        [DataType(DataType.EmailAddress)]
        [Key]
            public string Email { get; set; }

            [Required]
            public string Token { get; set; }

            [Required]
            [MinLength(8, ErrorMessage = "كلمة المرور يجب أن تكون على الأقل 8 أحرف")]
            [DataType(DataType.Password)]
            public string NewPassword { get; set; }

            [Required]
            [Compare("NewPassword", ErrorMessage = "كلمتا المرور غير متطابقتين")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
        
    }

}
