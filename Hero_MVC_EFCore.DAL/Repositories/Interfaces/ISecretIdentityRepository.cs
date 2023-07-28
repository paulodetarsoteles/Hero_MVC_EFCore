using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface ISecretIdentityRepository
    {
        Hero GetHero();
    }
}
