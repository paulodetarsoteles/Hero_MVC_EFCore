using AutoMapper;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

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
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao XXX - {ex.Message}");
                throw new Exception($"Erro ao XXX - {ex.Message}");
            }
        }

        public PowerViewModel GetById(int id)
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

        public void Insert(PowerViewModel viewModel)
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

        public void Update(PowerViewModel viewModel)
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
