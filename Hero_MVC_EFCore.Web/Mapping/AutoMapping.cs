using AutoMapper;
using Hero_MVC_EFCore.Domain.Models;
using Hero_MVC_EFCore.Web.ViewModels;

namespace Hero_MVC_EFCore.Web.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Film, FilmViewModel>();
            CreateMap<FilmViewModel, Film>();
            CreateMap<Hero, HeroViewModel>();
            CreateMap<HeroViewModel, Hero>();
            CreateMap<Power, PowerViewModel>();
            CreateMap<PowerViewModel, Power>();
            CreateMap<SecretIdentity, SecretIdentityViewModel>();
            CreateMap<SecretIdentityViewModel, SecretIdentity>();
        }
    }
}
