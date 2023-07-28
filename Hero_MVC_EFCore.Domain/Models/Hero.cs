namespace Hero_MVC_EFCore.Domain.Models
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Comments { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<Power> Powers { get; set; }
    }
}
