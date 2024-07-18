using System.ComponentModel.DataAnnotations;

namespace Quete_ASP_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Error: Title required!")]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Error: Content required!")]
        [Display(Name = "Content")]
        public string Content { get; set; } = string.Empty;
       
      
    }

}

    

