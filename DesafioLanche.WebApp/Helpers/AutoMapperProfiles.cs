using AutoMapper;
using DesafioLanche.DTO;
using DesafioLanche.WebApp.ViewModels;
using System.Linq;

namespace DesafioLanche.WebApp.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<IngredienteDTO, IngredienteViewModel>().ReverseMap();
            CreateMap<IngredienteStatusDTO, IngredienteStatusViewModel>().ReverseMap();

            CreateMap<LancheDTO, LancheViewModel>()
                .ForMember(dest => dest.Ingredientes,
                    opt => opt.MapFrom(src => src.LancheXingredientes.Select(a => a.Ingrediente)))
                    .ReverseMap();
            CreateMap<LancheStatusDTO, LancheStatusViewModel>().ReverseMap();

            CreateMap<PromocaoDTO, PromocaoViewModel>()
               .ForMember(dest => dest.Ingredientes,
                   opt => opt.MapFrom(src => src.PromocaoXingredientes))
                   .ReverseMap();
            CreateMap<PromocaoStatusDTO, PromocaoStatusViewModel>().ReverseMap();

            CreateMap<PromocaoXingredienteDTO, PromocaoXingredienteViewModel>().ReverseMap();


        }
    }
}
