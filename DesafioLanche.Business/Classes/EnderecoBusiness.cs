using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class EnderecoBusiness : IEnderecoBusiness
    {
        private readonly IEnderecoRepository repo;
        private readonly IMapper mapper;

        public EnderecoBusiness(IEnderecoRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<EnderecoDTO> Create(EnderecoDTO enderecoDTO)
        {
            var endereco = this.mapper.Map<Endereco>(enderecoDTO);
            var result = await this.repo.Create(endereco);
            return this.mapper.Map<EnderecoDTO>(result);
        }

        public async Task<bool> Delete(EnderecoDTO enderecoDTO)
        {
            var endereco = this.mapper.Map<Endereco>(enderecoDTO);
            return await this.repo.Delete(endereco.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<EnderecoDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<EnderecoDTO>>(result);
        }

        public async Task<EnderecoDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<EnderecoDTO>(result);
        }

        public async Task<EnderecoDTO> Update(EnderecoDTO enderecoDTO)
        {
            var endereco = this.mapper.Map<Endereco>(enderecoDTO);
            var result = await this.repo.Update(endereco);
            return this.mapper.Map<EnderecoDTO>(result);
        }
    }
}
