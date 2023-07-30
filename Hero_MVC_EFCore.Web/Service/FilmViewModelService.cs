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
                Console.WriteLine($"Erro ao buscar filme - Id: {id} - {ex.Message}");
                throw new Exception($"Erro ao buscar filme - Id: {id} - {ex.Message}");
            }
        }

        public List<HeroViewModel> GetHeroes(FilmViewModel viewModel)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao XXX - {ex.Message}");
                throw new Exception($"Erro ao XXX - {ex.Message}");
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
                Console.WriteLine($"Erro ao XXX - {ex.Message}");
                throw new Exception($"Erro ao XXX - {ex.Message}");
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
                Console.WriteLine($"Erro ao inserir filme - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Erro ao inserir filme - {viewModel.Name} - {ex.Message}");
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
                Console.WriteLine($"Erro ao atualizar filme - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Erro ao atualizarr filme - {viewModel.Name} - {ex.Message}");
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
                Console.WriteLine($"Erro ao excluir filme - Id: {id} - {ex.Message}");
                throw new Exception($"Erro ao excluir filme - Id: {ex.Message}");
            }
        }
    }
}
