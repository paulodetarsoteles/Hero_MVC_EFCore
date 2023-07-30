using Hero_MVC_EFCore.Domain.Models;

namespace Hero_MVC_EFCore.DAL.Repositories.Interfaces
{
    public interface IPowerRepository
    {
        List<Power> GetAll();
        Power? GetById(int id);
        void Insert(Power entity);
        void Update(Power entity);
        void Delete(int id);
        Hero GetHero(Power entity);
    }
}
