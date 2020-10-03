using AutoMapper;
using DesafioLanche.Business.Interfaces;
using DesafioLanche.Domain;
using DesafioLanche.DTO;
using DesafioLanche.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioLanche.Business.Classes
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteRepository repo;
        private readonly IMapper mapper;

        public ClienteBusiness(IClienteRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<ClienteDTO> Create(ClienteDTO clienteDTO)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDTO);
            var result = await this.repo.Create(cliente);
            return this.mapper.Map<ClienteDTO>(result);
        }

        public async Task<bool> Delete(ClienteDTO clienteDTO)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDTO);
            return await this.repo.Delete(cliente.Id);
        }

        public async Task<bool> Exists(long? id)
        {
            return await this.repo.Exists(id);
        }

        public async Task<List<ClienteDTO>> FindAllAsync(bool asNoTracking = false)
        {
            var result = await this.repo.FindAllAsync(asNoTracking);
            return this.mapper.Map<List<ClienteDTO>>(result);
        }

        public async Task<ClienteDTO> FindByIdAsync(long id, bool asNoTracking = false)
        {
            var result = await this.repo.FindByIdAsync(id, asNoTracking);
            return this.mapper.Map<ClienteDTO>(result);
        }

        public async Task<ClienteDTO> Update(ClienteDTO clienteDTO)
        {
            var cliente = this.mapper.Map<Cliente>(clienteDTO);
            var result = await this.repo.Update(cliente);
            return this.mapper.Map<ClienteDTO>(result);
        }
    }
}
