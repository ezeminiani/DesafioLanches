using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IIngredienteBusiness
    {
        Task<IngredienteDTO> Create(IngredienteDTO ingredienteDTO);

        Task<IngredienteDTO> Update(IngredienteDTO ingredienteDTO);

        Task<bool> Delete(IngredienteDTO ingredienteDTO);

        Task<bool> Exists(long? id);

        Task<IngredienteDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<IngredienteDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
