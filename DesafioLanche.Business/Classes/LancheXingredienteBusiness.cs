using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class LancheXingredienteBusiness : ILancheXingredienteBusiness
    {
        private readonly ILancheXingredienteRepository repo;
        private readonly IMapper mapper;

        public LancheXingredienteBusiness(ILancheXingredienteRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<LancheXingredienteDTO> Create(LancheXingredienteDTO lancheXingredienteDTO)
        {
            var lancheXingrediente = this.mapper.Map<LancheXingrediente>(lancheXingredienteDTO);
            var result = await this.repo.Create(lancheXingrediente);
            return this.mapper.Map<LancheXingredienteDTO>(result);
        }

        public async Task<bool> Delete(LancheXingredienteDTO lancheXingredienteDTO)
        {
            var lancheXingrediente = this.mapper.Map<LancheXingrediente>(lancheXingredienteDTO);
            return await this.repo.Delete(lancheXingrediente.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<LancheXingredienteDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<LancheXingredienteDTO>>(result);
        }

        public async Task<LancheXingredienteDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<LancheXingredienteDTO>(result);
        }


        public async Task<LancheXingredienteDTO> Update(LancheXingredienteDTO lancheXingredienteDTO)
        {
            var lancheXingrediente = this.mapper.Map<LancheXingrediente>(lancheXingredienteDTO);
            var result = await this.repo.Update(lancheXingrediente);
            return this.mapper.Map<LancheXingredienteDTO>(result);
        }

      
    }
}
