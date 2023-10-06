using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories.Common;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Repositories
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(DataContext dataContext) : base(dataContext) { }

        public List<Hero> GetAllHeroes()
        {
            try
            {
                return _dbContext.Heroes
                    .AsNoTracking()
                    .ToList(); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar heróis - {ex.Message}");
                throw new Exception("Erro ao buscar heróis");
            }
        }

        public override Film GetById(int id)
        {
            return _dbContext.Films
                .Include(f => f.Heroes)
                .First(f => f.FilmId == id);
        }

        public bool IsPresent(Film film, Hero hero)
        {
            try
            {
                Film filmRestult = _dbContext.Films.FirstOrDefault(film);

                if (filmRestult.Heroes.FirstOrDefault(hero) is null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar se heróis e filmes tem vínculo - {ex.Message}");
                throw new Exception("Erro ao verificar se heróis e filmes tem vínculo");
            }
        }

        public void UpdateHeroes(Film entity)
        {
            List<FilmsHeroes> relations = _dbContext.FilmsHeroes.Where(r => r.FilmId == entity.FilmId).ToList();
            
            if (relations.Count > 0 )
            {
                _dbContext.FilmsHeroes.RemoveRange(relations);
                _dbContext.SaveChanges();
            }

            relations.Clear();

            var heroes = entity.Heroes;

            foreach (var hero in heroes)
            {
                relations.Add(new FilmsHeroes 
                {
                    FilmId = entity.FilmId,
                    HeroId = hero.HeroId
                });
            }

            _dbContext.AddRange(relations);

            _dbContext.SaveChanges();
        }
    }
}
