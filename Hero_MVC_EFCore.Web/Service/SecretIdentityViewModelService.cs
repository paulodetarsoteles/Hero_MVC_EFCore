using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;
using System.Reflection;

namespace Hero_MVC_EFCore.Web.Service
{
    public class SecretIdentityViewModelService : ISecretIdentityViewModelService
    {
        private readonly ISecretIdentityRepository _secretIdentityRepository;
        private readonly IMapper _mapper;

        public SecretIdentityViewModelService(ISecretIdentityRepository secretIdentityRepository, IMapper mapper)
        {
            _secretIdentityRepository = secretIdentityRepository;
            _mapper = mapper;
        }

        public List<SecretIdentityViewModel> GetAll()
        {
            try
            {
                var result = _secretIdentityRepository.GetAll();

                if (result == null)
                    throw new Exception("Lista de identidades secretas retornou nula.");

                return _mapper.Map<List<SecretIdentityViewModel>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Identidade secreta - {MethodBase.GetCurrentMethod()} - {ex.Message}");
            }
        }

        public SecretIdentityViewModel GetById(int id)
        {
            try
            {
                var result = _secretIdentityRepository.GetById(id);

                if (result is null)
                    throw new Exception("Não foi encontrado identidade secreta com este Id.");

                return _mapper.Map<SecretIdentityViewModel>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Identidade Secreta - {MethodBase.GetCurrentMethod()} - {id} - {ex.Message}");
                throw new Exception($"Identidade Secreta - {ex.Message}");
            }
        }

        public void Insert(SecretIdentityViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<SecretIdentity>(viewModel);
                _secretIdentityRepository.Insert(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Identidade Secreta - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Identidade Secreta - {ex.Message}");
            }
        }

        public void Update(SecretIdentityViewModel viewModel)
        {
            try
            {
                var entity = _mapper.Map<SecretIdentity>(viewModel);
                _secretIdentityRepository.Update(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Identidade Secreta - {MethodBase.GetCurrentMethod()} - {viewModel.Name} - {ex.Message}");
                throw new Exception($"Identidade Secreta - {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _secretIdentityRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Identidade Secreta - {MethodBase.GetCurrentMethod()} - {id} - {ex.Message}");
                throw new Exception($"Identidade Secreta - {ex.Message}");
            }
        }
    }
}
