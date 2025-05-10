using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithYou_project.Database.Entities
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        [ForeignKey("Psychologist")]
        public int PsychologistId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Publish date is required")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        //  Navigation properties
        public Psychologist Psychologist { get; set; }
    }
}
