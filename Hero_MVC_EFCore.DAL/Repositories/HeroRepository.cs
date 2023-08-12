using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<Hero> GetAll()
        {
            try
            {
                return _dbContext.Heroes.Include(h => h.SecretIdentity).Include(h => h.Powers).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar lista de poderes/armas");
                throw new Exception($"Erro ao buscar lista de poderes/armas - {ex.Message}");
            }
        }

        public override Hero GetById(int id)
        {
            Hero hero = _dbContext.Heroes.Include(h => h.SecretIdentity).Include(h => h.Powers).Include(h => h.Films).First(h => h.HeroId == id);
            return hero;
        }

        public List<Power> GetAllPowers()
        {
            try
            {
                List<Power> result = new();
                result = _dbContext.Powers.AsNoTracking().ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar lista de poderes/armas");
                throw new Exception($"Erro ao buscar lista de poderes/armas - {ex.Message}");
            }
        }

        public List<SecretIdentity> GetAllSecretIdentities()
        {
            try
            {
                List<SecretIdentity> result = new();
                result = _dbContext.SecretIdentities.ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar lista de identidades secretas");
                throw new Exception($"Erro ao buscar lista de identidades secretas - {ex.Message}");
            }
        }

        public SecretIdentity GetSecretIdentity(Hero entity)
        {
            try
            {
                SecretIdentity result = new();
                result = _dbContext.SecretIdentities.First(x => x.SecretIdentityId == entity.SecretIdentityId);

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar identidade secreta");
                throw new Exception($"Erro ao buscar identidade secreta - {ex.Message}");
            }
        }

        public bool HasPower(Hero entity)
        {
            try
            {
                return _dbContext.Heroes.First(x => x.HeroId == entity.HeroId).Powers.Any();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao vericar se o herói tem poder/arma");
                throw new Exception($"Erro vericar se o herói tem poder/arma - {ex.Message}");
            }
        }

        public int CountFilms(Hero entity)
        {
            try
            {
                return _dbContext.Heroes.First(x => x.HeroId == entity.HeroId).Films.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao contar filmes do herói");
                throw new Exception($"Erro ao contar filmes do herói - {ex.Message}");
            }
        }

        public int InsertHero(Hero entity)
        {
            try
            {
                _dbContext.AddAsync(entity);
                _dbContext.SaveChanges();

                return _dbContext.Heroes.OrderByDescending(h => h.HeroId).First().HeroId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir entidade");
                throw new Exception($"Erro ao inserir entidade - {ex.Message}");
            }
        }

        public void CleanPowers(int heroId)
        {
            try
            {
                List<Power> powers = _dbContext.Powers.Where(p => p.HeroId ==  heroId).AsNoTracking().ToList();
                powers.ForEach(power => power.HeroId = null);

                _dbContext.UpdateRange(powers);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao limpar poderes");
                throw new Exception($"Erro ao limpar poderes - {ex.Message}");
            }
        }

        public void UpdatePowers(List<Power> entity)
        {
            try
            {
                _dbContext.UpdateRange(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar poder");
                throw new Exception($"Erro ao atualizar poder - {ex.Message}");
            }
        }
    }
}
