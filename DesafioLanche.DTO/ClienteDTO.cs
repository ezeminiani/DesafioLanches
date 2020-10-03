using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class ClienteDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DataMember(Order = 2)]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Apelido { get; set; }

        [DataMember(Order = 3)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }

        [DataMember(Order = 4)]
        public List<EnderecoDTO> Enderecos { get; set; }

        [DataMember(Order = 5)]
        public List<PedidoDTO> Pedidos { get; set; }
    }
}
