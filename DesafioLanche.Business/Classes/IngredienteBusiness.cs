using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class IngredienteBusiness : IIngredienteBusiness
    {
        private readonly IIngredienteRepository repo;
        private readonly IMapper mapper;

        public IngredienteBusiness(IIngredienteRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IngredienteDTO> Create(IngredienteDTO ingredienteDTO)
        {
            var ingrediente = this.mapper.Map<Ingrediente>(ingredienteDTO);
            var result = await this.repo.Create(ingrediente);
            return this.mapper.Map<IngredienteDTO>(result);
        }

        public async Task<bool> Delete(IngredienteDTO ingredienteDTO)
        {
            var ingrediente = this.mapper.Map<Ingrediente>(ingredienteDTO);
            return await this.repo.Delete(ingrediente.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<IngredienteDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<IngredienteDTO>>(result);
        }

        public async Task<IngredienteDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<IngredienteDTO>(result);
        }

        public async Task<IngredienteDTO> Update(IngredienteDTO ingredienteDTO)
        {
            var ingrediente = this.mapper.Map<Ingrediente>(ingredienteDTO);
            var result = await this.repo.Update(ingrediente);
            return this.mapper.Map<IngredienteDTO>(result);
        }
    }
}
