using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service
{
    public class PowerViewModelService : IPowerViewModelService
    {
        private readonly IPowerRepository _powerRepository;

        public PowerViewModelService(IPowerRepository powerRepository)
        {
            _powerRepository = powerRepository;
        }

        public List<PowerViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PowerViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public HeroViewModel GetHero()
        {
            throw new NotImplementedException();
        }

        public void Insert(PowerViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(PowerViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
