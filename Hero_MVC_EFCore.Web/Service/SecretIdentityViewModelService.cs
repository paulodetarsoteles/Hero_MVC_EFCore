using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

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
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao XXX - {ex.Message}");
                throw new Exception($"Erro ao XXX - {ex.Message}");
            }
        }

        public SecretIdentityViewModel GetById(int id)
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

        public HeroViewModel GetHero()
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

        public void Insert(SecretIdentityViewModel viewModel)
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

        public void Update(SecretIdentityViewModel viewModel)
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

        public void Delete(int id)
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
    }
}
