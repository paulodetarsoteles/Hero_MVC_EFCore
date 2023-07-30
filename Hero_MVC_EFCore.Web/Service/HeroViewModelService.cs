using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

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
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao XXX - {ex.Message}");
                throw new Exception($"Erro ao XXX - {ex.Message}");
            }
        }

        public HeroViewModel GetById(int id)
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

        public List<PowerViewModel> GetPowers()
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

        public SecretIdentityViewModel GetSecretIdentity()
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

        public bool HasPower()
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

        public int CountFilms()
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

        public void Insert(HeroViewModel viewModel)
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

        public void Update(HeroViewModel viewModel)
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
