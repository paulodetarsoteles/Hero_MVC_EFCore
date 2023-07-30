using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service.Interfaces
{
    public interface IPowerViewModelService
    {
        List<PowerViewModel> GetAll();
        PowerViewModel GetById(int id);
        void Insert(PowerViewModel viewModel);
        void Update(PowerViewModel viewModel);
        void Delete(int id);

        HeroViewModel GetHero(PowerViewModel viewModel);
    }
}
