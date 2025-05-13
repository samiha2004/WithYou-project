using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WithYou_project.Models
{
    public class ApplicationUser : IdentityUser
    {
        // الاسم الكامل
        public string FullName { get; set; } = string.Empty;

        // رقم الهاتف يتم توريثه من IdentityUser

        // معلومات الأخصائي (تكون فارغة للمستخدم العادي)
        public string? Specialty { get; set; }
        public string? LicenseNumber { get; set; }
        public int? YearsExperience { get; set; }

        // الموافقة على الشروط
        public bool AcceptTerms { get; set; }

        // نوع الحساب (مستخدم / أخصائي)
        public string AccountType { get; set; } = "Patient";


        public string ProfileImagePath { get; set; }
        public string CertificatesFilePath { get; set; }
    }
}

