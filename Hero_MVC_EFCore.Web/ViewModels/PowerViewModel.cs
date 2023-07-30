using Hero_MVC_EFCore.Domain.Enums;
using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hero_MVC_EFCore.Web.ViewModels
{
    public class PowerViewModel
    {
        [Key]
        [Display(Name = "Código do poder")]
        public int PowerId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public EnumPower? Type { get; set; } = null;

        [Display(Name = "Código do herói")]
        public int? HeroId { get; set; } = null;

        [NotMapped]
        [Display(Name = "Heróis")]
        public Hero Hero { get; set; }
    }
}
