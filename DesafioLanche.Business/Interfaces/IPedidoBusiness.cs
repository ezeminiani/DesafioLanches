using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IPedidoBusiness
    {
        Task<PedidoDTO> Create(PedidoDTO pedidoDTO);

        Task<PedidoDTO> Update(PedidoDTO pedidoDTO);

        Task<bool> Delete(PedidoDTO pedidoDTO);

        Task<bool> Exists(long? id);

        Task<PedidoDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<PedidoDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
