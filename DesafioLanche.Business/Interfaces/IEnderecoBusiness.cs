using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IEnderecoBusiness
    {
        Task<EnderecoDTO> Create(EnderecoDTO enderecoDTO);

        Task<EnderecoDTO> Update(EnderecoDTO enderecoDTO);

        Task<bool> Delete(EnderecoDTO enderecoDTO);

        Task<bool> Exists(long? id);

        Task<EnderecoDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<EnderecoDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
