namespace Hero_MVC_EFCore.Domain.Models
{
    public class FilmsHeroes
    {
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
        public int HeroId { get; set; }
        public virtual Hero Hero { get; set; }
    }
}
