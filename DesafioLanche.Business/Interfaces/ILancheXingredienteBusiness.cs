using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface ILancheXingredienteBusiness
    {
        Task<LancheXingredienteDTO> Create(LancheXingredienteDTO lancheXingredienteDTO);

        Task<LancheXingredienteDTO> Update(LancheXingredienteDTO lancheXingredienteDTO);

        Task<bool> Delete(LancheXingredienteDTO lancheXingredienteDTO);

        Task<bool> Exists(long? id);

        Task<LancheXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<LancheXingredienteDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
