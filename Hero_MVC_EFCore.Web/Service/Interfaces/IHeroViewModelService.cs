using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service.Interfaces
{
    public interface IHeroViewModelService
    {
        List<HeroViewModel> GetAll();
        HeroViewModel GetById(int id);
        void Insert(HeroViewModel viewModel);
        void Update(HeroViewModel viewModel);
        void Delete(int id);

        List<PowerViewModel> GetAllPowers();
        List<PowerViewModel> GetPowers(int id);
        List<SecretIdentityViewModel> GetAllSecretIdentities();
        SecretIdentityViewModel GetSecretIdentity(HeroViewModel viewModel);
        bool HasPower(HeroViewModel viewModel);
        int CountFilms(HeroViewModel viewModel);
        public void UpdatePowers(int heroId, List<PowerViewModel> viewModel);
        public int InsertHero(HeroViewModel viewModel);
    }
}
