using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace WithYou_project.Database.Entities;

    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginViewModel Login { get; set; }

        [BindProperty]
        public RegisterViewModel Register { get; set; }

        public void OnGet()
        {
            // أي تحميل مبدئي
        }

        public IActionResult OnPostLogin()
        {
            if (!ModelState.IsValid)
                return Page();

            // التحقق من بيانات تسجيل الدخول هنا...
            // مثال:
            if (Login.Email == "admin@test.com" && Login.Password == "123456")
            {
                // نجاح تسجيل الدخول
                return RedirectToPage("/Dashboard");
            }

            ModelState.AddModelError(string.Empty, "بيانات الدخول غير صحيحة");
            return Page();
        }

        public IActionResult OnPostRegister()
        {
            if (!ModelState.IsValid)
                return Page();

            // معالجة إنشاء الحساب هنا...
            // يمكنك حفظ البيانات في قاعدة البيانات

            // مثال:
            TempData["SuccessMessage"] = "تم إنشاء الحساب بنجاح!";
            return RedirectToPage("/Login");
        }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "صيغة البريد غير صحيحة")]
        public string Email { get; set; }

        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
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

        // حقول خاصة بالأخصائي
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
        public int? YearsExperience { get; set; }

        [BindProperty]
        public IFormFile ProfileImage { get; set; }

        [BindProperty]
        public IFormFile CertificatesFile { get; set; }

        [Required(ErrorMessage = "يجب الموافقة على الشروط")]
        public bool AcceptTerms { get; set; }
    }





