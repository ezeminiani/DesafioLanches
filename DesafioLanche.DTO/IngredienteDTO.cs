using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class IngredienteDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DataMember(Order = 2)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(1024, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 1024 caracteres")]
        public string Descricao { get; set; }

        [DataMember(Order = 3)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido (somente números)")]
        public decimal Preco { get; set; }

        [DataMember(Order = 4)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [EnumDataType(typeof(IngredienteStatusDTO), ErrorMessage = "Status inválido")]
        public IngredienteStatusDTO Status { get; set; }

        [DataMember(Order = 5)]
        public virtual List<LancheXingredienteDTO> LancheXingredientes { get; set; }

    }


    public enum IngredienteStatusDTO
    {
        INATIVO,
        ATIVO
    }
}
