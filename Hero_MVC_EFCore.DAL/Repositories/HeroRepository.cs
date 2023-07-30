using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public List<Power> GetPowers(Hero entity)
        {
            throw new NotImplementedException();
        }

        public SecretIdentity GetSecretIdentity(Hero entity)
        {
            throw new NotImplementedException();
        }

        public bool HasPower(Hero entity)
        {
            throw new NotImplementedException();
        }

        public int CountFilms(Hero entity)
        {
            throw new NotImplementedException();
        }
    }
}
