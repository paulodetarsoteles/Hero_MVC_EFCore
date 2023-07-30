using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service.Interfaces
{
    public interface IFilmViewModelService
    {
        List<FilmViewModel> GetAll();
        FilmViewModel GetById(int id);
        void Insert(FilmViewModel viewModel);
        void Update(FilmViewModel viewModel);
        void Delete(int id);

        List<HeroViewModel> GetHeroes(FilmViewModel viewModel);
        bool IsPresent(FilmViewModel filmViewModel, HeroViewModel heroViewModel);
    }
}
