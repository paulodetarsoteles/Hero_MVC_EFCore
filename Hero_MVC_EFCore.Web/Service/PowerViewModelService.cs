using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using System.Reflection;

namespace Hero_MVC_EFCore.Web.Service
{
    public class PowerViewModelService : IPowerViewModelService
    {
        private readonly IPowerRepository _powerRepository;
        private readonly IMapper _mapper;

        public PowerViewModelService(IPowerRepository powerRepository, IMapper mapper)
        {
            _powerRepository = powerRepository;
            _mapper = mapper;
        }

        public List<PowerViewModel> GetAll()
        {
            try
            {
                var result = _powerRepository.GetAll();

                if (result is null)
                    throw new Exception("Lista de poderes retornou nula.");

                return _mapper.Map<List<PowerViewModel>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public PowerViewModel GetById(int id)
        {
            try
            {
                var result = _powerRepository.GetById(id);

                if (result is null)
                    throw new Exception("Não foi encontrado poder com este Id.");

                return _mapper.Map<PowerViewModel>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - Id:{id} - {ex.Message}");
            }
        }

        public void Insert(PowerViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Power>(viewModel);
                _powerRepository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
            }
        }

        public void Update(PowerViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<Power>(viewModel);
                _powerRepository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _powerRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - Id:{id} - {ex.Message}");
            }
        }

        #region Especific Methods

        public HeroViewModel GetHero()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw new Exception($"Poder - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        #endregion
    }
}
