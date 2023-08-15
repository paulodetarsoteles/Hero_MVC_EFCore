using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using System.Reflection;

namespace Hero_MVC_EFCore.Web.Service
{
    public class FilmViewModelService : IFilmViewModelService
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IMapper _mapper;

        public FilmViewModelService(IFilmRepository filmRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _mapper = mapper;
        }

        public List<FilmViewModel> GetAll()
        {
            try
            {
                var result = _filmRepository.GetAll();

                if (result is null)
                    throw new Exception("Lista de filmes retornou nula.");

                return _mapper.Map<List<FilmViewModel>>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        public FilmViewModel GetById(int id)
        {
            try
            {
                var result = _filmRepository.GetById(id);

                if (result is null)
                    throw new Exception("Não foi encontrado filme com este Id.");

                return _mapper.Map<FilmViewModel>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {id} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        public void Insert(FilmViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Film>(viewModel);
                _filmRepository.Insert(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        public void Update(FilmViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Film>(viewModel);
                _filmRepository.Update(entity);
                _filmRepository.UpdateHeroes(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _filmRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {id} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        #region Especific Methods

        public List<HeroViewModel> GetAllHeroes()
        {
            try
            {
                var result = _filmRepository.GetAllHeroes();

                if (result is null)
                    throw new Exception("Lista de heróis retornou nula.");

                return _mapper.Map<List<HeroViewModel>>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        public bool IsPresent(FilmViewModel filmViewModel, HeroViewModel heroViewModel)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Filme - {MethodBase.GetCurrentMethod()} - {filmViewModel.Name} - {heroViewModel.Name} - {ex.Message}");
                throw new Exception($"Filme - {ex.Message}");
            }
        }

        #endregion
    }
}
