using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int Rate { get; set; } = 7;

        [NotMapped]
        [Display(Name = "Heróis")]
        public List<Hero> Heroes { get; set; }
    }
}
