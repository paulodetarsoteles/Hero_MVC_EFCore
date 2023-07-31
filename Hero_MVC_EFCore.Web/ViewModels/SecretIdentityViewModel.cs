using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hero_MVC_EFCore.Web.ViewModels
{
    public class SecretIdentityViewModel
    {
        [Key]
        [Display(Name = "Código")]
        public int SecretIdentityId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Comentários")]
        public string Comments { get; set; } = String.Empty;

        [Display(Name = "Última atualização")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        [NotMapped]
        [Display(Name = "Herói")]
        public Hero Hero { get; set; }
    }
}
