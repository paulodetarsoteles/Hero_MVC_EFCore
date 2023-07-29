using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Hero> GetHeroes()
        {
            throw new NotImplementedException();
        }

        public bool IsPresent(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
