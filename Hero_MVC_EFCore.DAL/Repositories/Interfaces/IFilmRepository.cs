using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface IFilmRepository
    {
        List<Hero> GetHeroes();
        bool IsPresent(Hero hero);
    }
}
