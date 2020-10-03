using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IPedidoXlancheXingredienteBusiness
    {
        Task<PedidoXlancheXingredienteDTO> Create(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO);

        Task<PedidoXlancheXingredienteDTO> Update(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO);

        Task<bool> Delete(PedidoXlancheXingredienteDTO pedidoXlancheXingredienteDTO);

        Task<bool> Exists(long? id);

        Task<PedidoXlancheXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<PedidoXlancheXingredienteDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
