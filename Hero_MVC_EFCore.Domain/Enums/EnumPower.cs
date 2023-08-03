using System.ComponentModel.DataAnnotations;

namespace Hero_MVC_EFCore.Domain.Enums
{
    public enum EnumPower
    {
        [Display(Name = "Poder")]
        Power = 0,

        [Display(Name = "Arma")]
        Weapon = 1
    }
}
