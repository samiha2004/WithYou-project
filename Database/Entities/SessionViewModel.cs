using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Session
    {
        [Key]
        public int Session_Id { get; set; }
        [Key]
        public int Psychologist_Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }
        [DataType(DataType.Time)]
        public string Time { get; set; }
    }
}
