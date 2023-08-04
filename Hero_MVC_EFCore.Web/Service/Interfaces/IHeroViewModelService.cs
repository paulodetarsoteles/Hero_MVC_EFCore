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
        List<PowerViewModel> GetPowers(HeroViewModel viewModel);
        List<SecretIdentityViewModel> GetAllSecretIdentities();
        SecretIdentityViewModel GetSecretIdentity(HeroViewModel viewModel);
        bool HasPower(HeroViewModel viewModel);
        int CountFilms(HeroViewModel viewModel);
    }
}
