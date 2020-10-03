using AutoMapper;
using DesafioLanche.Domain;
using DesafioLanche.DTO;

namespace DesafioLanche.Business.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<Ingrediente, IngredienteDTO>().ReverseMap();
            CreateMap<IngredienteStatus, IngredienteStatusDTO>().ReverseMap();
            CreateMap<Lanche, LancheDTO>().ReverseMap();
            CreateMap<LancheStatus, LancheStatusDTO>().ReverseMap();
            CreateMap<LancheXingrediente, LancheXingredienteDTO>().ReverseMap();
            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<PedidoXlancheXingrediente, PedidoXlancheXingredienteDTO>().ReverseMap();
            CreateMap<Promocao, PromocaoDTO>().ReverseMap();
            CreateMap<PromocaoStatus, PromocaoStatusDTO>().ReverseMap();
            CreateMap<PromocaoXingrediente, PromocaoXingredienteDTO>().ReverseMap();
        }
    }
}
