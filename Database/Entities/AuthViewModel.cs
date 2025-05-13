using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class AuthViewModel
    {
        [Key]
        public int Id { get; set; }
        // Login Properties
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "صيغة البريد غير صحيحة")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }

        // Register Properties
        [Required(ErrorMessage = "الاسم الكامل مطلوب")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "صيغة البريد غير صحيحة")]
        public string Email { get; set; }

        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
        [Phone(ErrorMessage = "رقم الهاتف غير صحيح")]
        public string Phone { get; set; }

        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
        public int? YearsExperience { get; set; }

        public String ProfileImage { get; set; }
        public String CertificatesFile { get; set; }

        [Required(ErrorMessage = "يجب الموافقة على الشروط")]
        public bool AcceptTerms { get; set; }

        [Required(ErrorMessage = "يجب اختيار نوع الحساب")]
        public string AccountType { get; set; }
    }
}
