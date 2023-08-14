using System.ComponentModel.DataAnnotations;

namespace Hero_MVC_EFCore.Web.ViewModels
{
    public class FilmViewModel
    {
        [Key]
        [Display(Name = "Código do filme")]
        public int FilmId { get; set; }

        [Required]
        [Display(Name = "Filme")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Nota")]
        [RegularExpression("([0-1-2-3-4-5-6-7-8-9-10])", ErrorMessage = "Digíte uma nota válida de 0 a 10")]
        public int Rate { get; set; }

        [Display(Name = "Heróis")]
        public List<HeroViewModel> Heroes { get; set; }
    }
}
