using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

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
                return _mapper.Map<List<FilmViewModel>>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar filmes - {ex.Message}");
                throw new Exception($"Erro ao buscar filmes - {ex.Message}");
            }
        }

        public FilmViewModel GetById(int id)
        {
            try
            {
                var result = _filmRepository.GetById(id);
                return _mapper.Map<FilmViewModel>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar filme - {ex.Message}");
                throw new Exception($"Erro ao buscar filme - {ex.Message}");
            }
        }

        public List<HeroViewModel> GetHeroes(FilmViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public bool IsPresent(FilmViewModel filmViewModel, HeroViewModel heroViewModel)
        {
            throw new NotImplementedException();
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
                Console.WriteLine($"Erro ao inserir filme - {ex.Message}");
                throw new Exception($"Erro ao inserir filme - {ex.Message}");
            }
        }

        public void Update(FilmViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Film>(viewModel);
                _filmRepository.Update(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir filme - {ex.Message}");
                throw new Exception($"Erro ao inserir filme - {ex.Message}");
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
                Console.WriteLine($"Erro ao inserir filme - {ex.Message}");
                throw new Exception($"Erro ao inserir filme - {ex.Message}");
            }
        }
    }
}
