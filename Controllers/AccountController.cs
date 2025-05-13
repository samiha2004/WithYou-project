using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WithYou_project.Database.Entities;
using WithYou_project.Models;
using System;
using WithYou_project.Database;



namespace WithYou_project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new AuthViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AuthViewModel model, string handler)
        {
            if (handler == "Login")
            {
                // تسجيل الدخول
                if (ModelState.IsValid)
                {
                   
                    var result = await _signInManager.PasswordSignInAsync(model.LoginEmail, model.LoginPassword, false, false);
                    if (result.Succeeded)
                    {
                        var userProfile = new UserProfile
                        {
                            FullName = model.FullName,
                            Email = model.Email,
                            Phone = model.Phone,
                            Specialty = model.Specialty,
                            LicenseNumber = model.LicenseNumber,
                            YearsExperience = model.YearsExperience,
                            ProfileImage = model.ProfileImage,
                            CertificatesFile = model.CertificatesFile,
                            AccountType = model.AccountType
                        };

                        _context.UserProfiles.Add(userProfile);
                        await _context.SaveChangesAsync();


                        TempData["SuccessMessage"] = "تم تسجيل الدخول بنجاح.";
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(string.Empty, "بيانات الدخول غير صحيحة.");
                }
            }
            else if (handler == "Register")
            {
               
                // إنشاء حساب جديد
                if (ModelState.IsValid)
                {
                    var fullNameParts = model.FullName?.Split(' ', 2);
                    var firstName = fullNameParts?[0] ?? "";
                    var lastName = fullNameParts?.Length > 1 ? fullNameParts[1] : "";

                    var user = new ApplicationUser
                    {
                        UserName = model.Email,
                        Email = model.Email,
                        PhoneNumber = model.Phone,
                       FullName = firstName,
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        TempData["SuccessMessage"] = "تم إنشاء الحساب .";
          
                        // رفع صورة ومرفقات إن وجدت (مسارات فقط)
                        if (Request.Form.Files.Count > 0)
                        {
                            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                            Directory.CreateDirectory(uploadsFolder);

                            foreach (var file in Request.Form.Files)
                            {
                                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                                var filePath = Path.Combine(uploadsFolder, fileName);

                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }

                                if (file.Name == nameof(model.ProfileImage))
                                    model.ProfileImage = "/uploads/" + fileName;

                                if (file.Name == nameof(model.CertificatesFile))
                                    model.CertificatesFile = "/uploads/" + fileName;
                            }
                        }

                        // هنا يمكنك إنشاء جدول منفصل للأطباء أو المستخدمين العاديين لتخزين معلومات إضافية

                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }

                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var model = new Resetpassword
            {
                Email = email,
                Token = token
            };
            return View(model);
        }

        // ✅ معالجة تعيين كلمة المرور (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(Resetpassword model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData["ErrorMessage"] = "هذا البريد غير مسجل.";
                return RedirectToAction("Login");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "تم تعيين كلمة المرور بنجاح.";
                return RedirectToAction("Login");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);

            return View(model);
        }
    
    [HttpGet]
        public IActionResult Resetemail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Resetemail(Resetemail model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // حتى لا نكشف ما إذا كان البريد موجود أو لا
                TempData["SuccessMessage"] = "تم إرسال رابط إعادة تعيين كلمة المرور إن وُجد الحساب.";
                return RedirectToAction("ForgotPasswordConfirmation");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetLink = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

            // هنا ترسل الإيميل 
            Console.WriteLine($"رابط إعادة التعيين: {resetLink}");

            TempData["SuccessMessage"] = "تم إرسال رابط إعادة تعيين كلمة المرور إلى بريدك الإلكتروني.";
            return RedirectToAction("ForgotPasswordConfirmation");
        }

        public IActionResult ResetemailConfirmation()
        {
            return View();
        }

    }
}
