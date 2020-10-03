using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class PromocaoDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        public virtual LancheDTO Lanche { get; set; }

        [DataMember(Order = 2)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DataMember(Order = 3)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(1024, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 1024 caracteres")]
        public string Descricao { get; set; }

        [DataMember(Order = 4)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido")]
        public decimal Desconto { get; set; }

        [DataMember(Order = 5)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [EnumDataType(typeof(PromocaoStatusDTO), ErrorMessage = "Status inválido")]
        public PromocaoStatusDTO Status { get; set; }

        [DataMember(Order = 6)]
        public virtual List<PromocaoXingredienteDTO> PromocaoXingredientes { get; set; }

    }

    public enum PromocaoStatusDTO
    {
        INATIVO,
        ATIVO
    }
}
