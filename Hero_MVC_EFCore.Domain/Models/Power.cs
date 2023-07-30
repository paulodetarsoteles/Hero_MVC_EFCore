using Hero_MVC_EFCore.Domain.Enums;

namespace Hero_MVC_EFCore.Domain.Models
{
    public class Power
    {
        public int PowerId { get; set; }
        public string Name { get; set; }
        public EnumPower? Type { get; set; }
        public int? HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
