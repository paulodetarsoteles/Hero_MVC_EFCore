using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface IFilmRepository
    {
        List<Film> GetAll();
        Film? GetById(int id);
        void Insert(Film entity);
        void Update(Film entity);
        void Delete(int id);

        List<Hero> GetAllHeroes();
        bool IsPresent(Film film, Hero hero);
    }
}
