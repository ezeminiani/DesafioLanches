using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class PedidoXlancheXingredienteDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        public virtual PedidoDTO Pedido { get; set; }

        [DataMember(Order = 2)]
        public virtual LancheDTO Lanche { get; set; }

        [DataMember(Order = 3)]
        public virtual IngredienteDTO Ingrediente { get; set; }

        [DataMember(Order = 4)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "campo {0} inválido")]
        public int Quantidade { get; set; }

        [DataMember(Order = 5)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "campo {0} inválido")]
        public decimal Valor { get; set; }
    }
}
