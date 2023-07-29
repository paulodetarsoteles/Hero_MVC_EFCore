namespace Hero_MVC_EFCore.Domain.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public List<Hero> Heroes { get; set; }
    }
}
