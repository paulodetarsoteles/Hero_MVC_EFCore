using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        [Display(Name = "Poderes ou armas")]
        public List<PowerViewModel> Powers { get; set; }

        [Display(Name = "Identidade secreta")]
        public int? SecretIdentityId { get; set; } = null;

        [NotMapped]
        [JsonIgnore]
        [Display(Name = "Identidades secretas")]
        public SecretIdentityViewModel SecretIdentity { get; set; }

        [NotMapped]
        [Display(Name = "Filmes")]
        public List<FilmViewModel> Films { get; set; }
    }
}
