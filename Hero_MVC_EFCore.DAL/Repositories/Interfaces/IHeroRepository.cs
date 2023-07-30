using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface IHeroRepository
    {
        List<Hero> GetAll();
        Hero? GetById(int id);
        void Insert(Hero entity);
        void Update(Hero entity);
        void Delete(int id);

        List<Power> GetPowers(Hero entity);
        SecretIdentity GetSecretIdentity(Hero entity);
        bool HasPower(Hero entity);
        int CountFilms(Hero entity);
    }
}
