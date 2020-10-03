using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IPromocaoBusiness
    {
        Task<PromocaoDTO> Create(PromocaoDTO promocaoDTO);

        Task<PromocaoDTO> Update(PromocaoDTO promocaoDTO);

        Task<bool> Delete(PromocaoDTO promocaoDTO);

        Task<bool> Exists(long? id);

        Task<PromocaoDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<PromocaoDTO>> FindAllAsync(bool asNoTracking = false);

        Task<List<PromocaoDTO>> SelectPromocaoByStatusAsync(PromocaoStatusDTO status, bool asNoTracking = false);
    }
}
