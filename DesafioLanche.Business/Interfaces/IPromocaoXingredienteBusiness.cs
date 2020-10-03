using DesafioLanche.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Interfaces
{
    public interface IPromocaoXingredienteBusiness
    {
        Task<PromocaoXingredienteDTO> Create(PromocaoXingredienteDTO promocaoXingredienteDTO);

        Task<PromocaoXingredienteDTO> Update(PromocaoXingredienteDTO promocaoXingredienteDTO);

        Task<bool> Delete(PromocaoXingredienteDTO promocaoXingredienteDTO);

        Task<bool> Exists(long? id);

        Task<PromocaoXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false);

        Task<List<PromocaoXingredienteDTO>> FindAllAsync(bool asNoTracking = false);
    }
}
