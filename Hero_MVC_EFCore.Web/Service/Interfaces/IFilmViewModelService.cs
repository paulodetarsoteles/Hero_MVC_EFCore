using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service.Interfaces
{
    public interface IFilmViewModelService
    {
        List<FilmViewModel> GetAll();
        FilmViewModel GetById(int id);
        List<HeroViewModel> GetHeroes();
        bool IsPresent(HeroViewModel viewModel);
        void Insert(FilmViewModel viewModel);
        void Update(HeroViewModel viewModel);
        void Delete(int id);
    }
}
