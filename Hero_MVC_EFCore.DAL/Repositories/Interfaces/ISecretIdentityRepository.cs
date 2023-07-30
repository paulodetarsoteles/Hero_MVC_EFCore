using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface ISecretIdentityRepository
    {
        List<SecretIdentity> GetAll();
        SecretIdentity? GetById(int id);
        void Insert(SecretIdentity entity);
        void Update(SecretIdentity entity);
        void Delete(int id);
        Hero GetHero(SecretIdentity entity);
    }
}
