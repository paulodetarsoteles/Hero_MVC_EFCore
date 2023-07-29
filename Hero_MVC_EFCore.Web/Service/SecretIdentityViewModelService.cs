using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Service
{
    public class SecretIdentityViewModelService : ISecretIdentityViewModelService
    {
        private readonly ISecretIdentityRepository _secretIdentityRepository;

        public SecretIdentityViewModelService(ISecretIdentityRepository secretIdentityRepository)
        {
            _secretIdentityRepository = secretIdentityRepository;
        }

        public List<SecretIdentityViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public SecretIdentityViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public HeroViewModel GetHero()
        {
            throw new NotImplementedException();
        }

        public void Insert(SecretIdentityViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(SecretIdentityViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
