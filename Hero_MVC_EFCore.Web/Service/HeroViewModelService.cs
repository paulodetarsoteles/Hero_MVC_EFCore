using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using System.Reflection;

namespace Hero_MVC_EFCore.Web.Service
{
    public class HeroViewModelService : IHeroViewModelService
    {
        private readonly IHeroRepository _heroRepository;
        private readonly IMapper _mapper;

        public HeroViewModelService(IHeroRepository heroRepository, IMapper mapper)
        {
            _heroRepository = heroRepository;
            _mapper = mapper;
        }

        public List<HeroViewModel> GetAll()
        {
            try
            {
                var result = _heroRepository.GetAll();

                if (result == null)
                    throw new Exception("A lista de heróis retornou nula.");

                return _mapper.Map<List<HeroViewModel>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public HeroViewModel GetById(int id)
        {
            try
            {
                var result = _heroRepository.GetById(id);

                if (result is null)
                    throw new Exception("Nenhum herói encontrado com este Id.");

                return _mapper.Map<HeroViewModel>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - Id:{id} - {ex.Message}");
            }
        }

        public void Insert(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);
                _heroRepository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
            }
        }

        public void Update(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);
                _heroRepository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _heroRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - Id:{id} - {ex.Message}");
            }
        }

        #region Especific Methods

        public List<PowerViewModel> GetAllPowers()
        {
            try
            {
                var entity = _heroRepository.GetAllPowers();
                return _mapper.Map<List<PowerViewModel>>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public List<PowerViewModel> GetPowers(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);
                var result = _heroRepository.GetPowers(entity);

                return _mapper.Map<List<PowerViewModel>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public List<SecretIdentityViewModel> GetAllSecretIdentities()
        {
            try
            {
                var result = _heroRepository.GetAllSecretIdentities();

                return _mapper.Map<List<SecretIdentityViewModel>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public SecretIdentityViewModel GetSecretIdentity(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);
                var result = _heroRepository.GetSecretIdentity(entity);

                return _mapper.Map<SecretIdentityViewModel>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public bool HasPower(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);

                return _heroRepository.HasPower(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public int CountFilms(HeroViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Hero>(viewModel);

                return _heroRepository.CountFilms(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Herói - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        #endregion
    }
}
