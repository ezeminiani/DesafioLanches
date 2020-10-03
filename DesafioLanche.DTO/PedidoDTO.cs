using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class PedidoDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        public virtual ClienteDTO Cliente { get; set; }

        [DataMember(Order = 2)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        public DateTime DataEmissao { get; set; }

        [DataMember(Order = 3)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido")]
        public decimal SubTotal { get; set; }

        [DataMember(Order = 4)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido")]
        public decimal DescontoTotal { get; set; }

        [DataMember(Order = 5)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido")]
        public decimal Total { get; set; }

        [DataMember(Order = 6)]
        public List<PedidoXlancheXingredienteDTO> PedidoXlancheXingredientes { get; set; }
    }
}
