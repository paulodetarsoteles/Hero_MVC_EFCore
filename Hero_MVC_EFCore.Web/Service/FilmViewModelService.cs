using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service
{
    public class FilmViewModelService : IFilmViewModelService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmViewModelService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public List<FilmViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public FilmViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HeroViewModel> GetHeroes()
        {
            throw new NotImplementedException();
        }

        public bool IsPresent(HeroViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Insert(FilmViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(HeroViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
