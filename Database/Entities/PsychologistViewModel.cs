using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Psychologist
    {
        [Key]
        public int Psychologist_Id { get; set; }
        public string Name { get; set; }
        public int YearOfExperience { get; set; }
        public string AboutMe { get; set; }
        public string Specialization { get; set; }
        public string Languages { get; set; }


    }
}
