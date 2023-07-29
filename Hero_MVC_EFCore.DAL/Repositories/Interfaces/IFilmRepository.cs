using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface IFilmRepository
    {
        IEnumerable<Film> GetAll();
        Film? GetById(int id);
        void Insert(Film entity);
        void Update(Film entity);
        void Delete(int id);
        List<Hero> GetHeroes();
        bool IsPresent(Hero hero);
    }
}
