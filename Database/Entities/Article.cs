using System.ComponentModel.DataAnnotations;

namespace WithYou_project.Database.Entities
{
    public class Article
    {
        [Key]
        [Required]
        public int Article_Id { get; set; }
        [Key]
        public int Psychologist_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string PublishDate { get; set; }

    }
}
