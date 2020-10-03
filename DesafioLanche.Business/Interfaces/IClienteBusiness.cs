using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IClienteBusiness
    {
        Task<ClienteDTO> Create(ClienteDTO clienteDTO);

        Task<ClienteDTO> Update(ClienteDTO clienteDTO);

        Task<bool> Delete(ClienteDTO clienteDTO);

        Task<bool> Exists(long? id);

        Task<ClienteDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<ClienteDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
