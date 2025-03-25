using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Review
    {
        [Key]
        public int Review_Id { get; set; }
        [Key]
        public int User_Id { get; set; }
        [Key]
        public int Psychologist_Id { get; set; }
        public string Comment { get; set; }
        [DataType(DataType.Date)]
        public string ReviewDate { get; set; }
        public string Rating { get; set; }


    }
}
