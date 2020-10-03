using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface ILancheBusiness
    {
        Task<LancheDTO> Create(LancheDTO lanche);

        Task<LancheDTO> Update(LancheDTO lanche);

        Task<bool> Delete(LancheDTO lanche);

        Task<bool> Exists(long? id);

        Task<LancheDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<LancheDTO>> FindAllAsync(bool asNoTracking = false);

        Task<List<LancheDTO>> SelectLancheByStatusAsync(LancheStatusDTO status, bool asNoTracking = false);
    }
}
