using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hero_MVC_EFCore.Web.ViewModels
{
    public class HeroViewModel
    {
        [Key]
        [Display(Name = "Código do herói")]
        public int HeroId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Ativo")]
        public bool Active { get; set; } = false;

        [Display(Name = "Comentário")]
        public string Comments { get; set; } = String.Empty;

        [Display(Name = "Última atualização")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        [NotMapped]
        [Display(Name = "Poderes ou armas")]
        public List<Power> Powers { get; set; }

        [Display(Name = "Identidade secreta")]
        public int SecretIdentityId { get; set; }

        [NotMapped]
        [Display(Name = "Identidades secretas")]
        public SecretIdentity SecretIdentity { get; set; }

        [NotMapped]
        [Display(Name = "Filmes")]
        public List<Film> Films { get; set; }
    }
}
