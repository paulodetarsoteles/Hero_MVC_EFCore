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
                Console.WriteLine($"Erro ao buscar heróis - {ex.Message}");
                throw new Exception("Erro ao buscar heróis");
            }
        }

        public bool IsPresent(Film film, Hero hero)
        {
            try
            {
                Film filmRestult = _dataContext.Films.FirstOrDefault(film);

                if (filmRestult.Heroes.FirstOrDefault(hero) is null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar se heróis e filmes tem vínculo - {ex.Message}");
                throw new Exception("Erro ao verificar se heróis e filmes tem vínculo");
            }
        }
    }
}
