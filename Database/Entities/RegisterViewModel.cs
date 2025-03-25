using System.ComponentModel.DataAnnotations;
namespace WithYou_project.Database.Entities

{
    public class Register
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "the{0} must be at least {5} charachters long.", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and Confirmation password do not match ")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string AdminCode { get; set; }
        [Required]
        public string Specilization { get; set; }
        [Required]
        public int YearsOfExperienc { get; set; }

        //LoginViewModel
        [Required]
        public string EmailLogin { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "the{0} must be at least {5} charachters long.", MinimumLength = 6)]
        public string PasswordLogin { get; set; }


    }
}

