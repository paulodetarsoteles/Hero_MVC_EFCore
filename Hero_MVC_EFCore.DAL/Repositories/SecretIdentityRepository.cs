using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class SecretIdentityRepository : BaseRepository<SecretIdentity>, ISecretIdentityRepository
    {
        public SecretIdentityRepository(DataContext dataContext) : base(dataContext) { }

        public override List<SecretIdentity> GetAll()
        {
            return _dbContext.SecretIdentities
                .Include(s => s.Hero)
                .AsNoTracking()
                .ToList();
        }
    }
}
