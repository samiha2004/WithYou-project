using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Admin
    {
        [Key]
        public int AdminCode { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
