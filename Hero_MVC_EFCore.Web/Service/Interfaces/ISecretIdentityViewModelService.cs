using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service.Interfaces
{
    public interface ISecretIdentityViewModelService
    {
        List<SecretIdentityViewModel> GetAll();
        SecretIdentityViewModel GetById(int id);
        void Insert(SecretIdentityViewModel viewModel);
        void Update(SecretIdentityViewModel viewModel);
        void Delete(int id);

        HeroViewModel GetHero();
    }
}
