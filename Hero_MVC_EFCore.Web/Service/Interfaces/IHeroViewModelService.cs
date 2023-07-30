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

        List<PowerViewModel> GetPowers(HeroViewModel viewModel);
        SecretIdentityViewModel GetSecretIdentity(HeroViewModel viewModel);
        bool HasPower(HeroViewModel viewModel);
        int CountFilms(HeroViewModel viewModel);
    }
}
