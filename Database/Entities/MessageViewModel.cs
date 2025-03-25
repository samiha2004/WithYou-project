using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Message
    {
        [Key]
        public int Message_Id { get; set; }
        [Key]
        public int Psychologist_Id { get; set; }
        [Key]
        public int User_Id { get; set; }
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        public string DateAndTime { get; set; }


    }
}
