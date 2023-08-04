﻿using Hero_MVC_EFCore.DAL.Data;
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

        public List<Power> GetAllPowers()
        {
            try
            {
                List<Power> result = new();
                result = _dbContext.Powers.ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar lista de poderes/armas");
                throw new Exception($"Erro ao buscar lista de poderes/armas - {ex.Message}");
            }
        }

        public List<Power> GetPowers(Hero entity)
        {
            try
            {
                List<Power> result = new();
                result = _dbContext.Powers.Where(x => x.HeroId == entity.HeroId).ToList();

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
    }
}
