using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(DataContext dataContext) : base(dataContext) { }

        public override List<Hero> GetAll()
        {
            try
            {
                return _dbContext.Heroes
                    .Include(h => h.SecretIdentity)
                    .Include(h => h.Powers)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar lista de heróis - {ex.Message}");
                throw new Exception("Erro ao buscar lista de heróis");
            }
        }

        public override Hero GetById(int id)
        {
            return _dbContext.Heroes
                .Include(h => h.SecretIdentity)
                .Include(h => h.Powers)
                .Include(h => h.Films)
                .First(h => h.HeroId == id); ;
        }

        public List<Power> GetAllPowers()
        {
            try
            {
                return _dbContext.Powers
                    .AsNoTracking()
                    .ToList(); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar lista de poderes/armas - {ex.Message}");
                throw new Exception("Erro ao buscar lista de poderes/armas");
            }
        }

        public List<SecretIdentity> GetAllSecretIdentities()
        {
            try
            {
                return _dbContext.SecretIdentities
                    .AsNoTracking()
                    .ToList(); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar lista de identidades secretas - {ex.Message}");
                throw new Exception("Erro ao buscar lista de identidades secretas");
            }
        }

        public bool HasPower(Hero entity)
        {
            try
            {
                return _dbContext.Heroes
                    .First(x => x.HeroId == entity.HeroId)
                    .Powers.Any();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro vericar se o herói tem poder/arma - {ex.Message}");
                throw new Exception("Erro vericar se o herói tem poder/arma");
            }
        }

        public int CountFilms(Hero entity)
        {
            try
            {
                return _dbContext.Heroes
                    .First(x => x.HeroId == entity.HeroId)
                    .Films.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao contar filmes do herói - {ex.Message}");
                throw new Exception("Erro ao contar filmes do herói");
            }
        }

        public int InsertHero(Hero entity)
        {
            try
            {
                _dbContext.AddAsync(entity);
                _dbContext.SaveChanges();

                return _dbContext.Heroes
                    .OrderByDescending(h => h.HeroId)
                    .First().HeroId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir entidade - {ex.Message}");
                throw new Exception("Erro ao inserir entidade");
            }
        }

        public void CleanPowers(int heroId)
        {
            try
            {
                List<Power> powers = _dbContext.Powers
                    .Where(p => p.HeroId == heroId)
                    .ToList();

                powers.ForEach(power => power.HeroId = null);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao limpar poderes - {ex.Message}");
                throw new Exception("Erro ao limpar poderes");
            }
        }

        public void UpdatePowers(List<Power> entityList)
        {
            try
            {
                foreach (Power entity in entityList)
                {
                    Power power = _dbContext.Powers.First(p => p.PowerId == entity.PowerId);

                    _dbContext.Entry(power).CurrentValues.SetValues(entity);
                    _dbContext.Update(power);
                }

                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar poder - {ex.Message}");
                throw new Exception("Erro ao atualizar poder");
            }
        }
    }
}
