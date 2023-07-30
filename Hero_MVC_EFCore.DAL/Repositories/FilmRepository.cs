using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        private readonly DataContext _dataContext;
        public FilmRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Hero> GetHeroes(Film film)
        {
            try
            {
                List<Hero> result = _dataContext.Films.FirstOrDefault(film).Heroes.ToList();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsPresent(Film film, Hero hero)
        {
            Film filmRestult = _dataContext.Films.FirstOrDefault(film);

            if (filmRestult.Heroes.FirstOrDefault(hero) is null)
                return false;

            return true;
        }
    }
}
