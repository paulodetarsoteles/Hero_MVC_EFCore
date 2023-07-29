using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service
{
    public class HeroViewModelService : IHeroViewModelService
    {
        private readonly IHeroRepository _heroRepository;

        public HeroViewModelService(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public List<HeroViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public HeroViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PowerViewModel> GetPowers()
        {
            throw new NotImplementedException();
        }

        public SecretIdentityViewModel GetSecretIdentity()
        {
            throw new NotImplementedException();
        }

        public bool HasPower()
        {
            throw new NotImplementedException();
        }

        public int CountFilms()
        {
            throw new NotImplementedException();
        }

        public void Insert(HeroViewModel viewModel)
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
