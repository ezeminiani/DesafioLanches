using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("PEDIDOxLANCHExINGREDIENTE")]
    public class PedidoXlancheXingrediente : BaseEntity
    {
        [Column("PliPedidoId")]
        public long PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido Pedido { get; set; }

        [Column("PliLancheId")]
        public long LancheId { get; set; }

        [ForeignKey("LancheId")]
        public virtual Lanche Lanche { get; set; }

        [Column("PliIngredienteId")]
        public long IngredienteId { get; set; }

        [ForeignKey("IngredienteId")]
        public virtual Ingrediente Ingrediente { get; set; }

        /// <summary>
        /// Quantidade no pedido do ingrediente.
        /// </summary>
        [Required]
        [Column("PliQuantidade")]
        public int Quantidade { get; set; }

        /// <summary>
        /// Valor dessa quantidade.
        /// </summary>
        [Required]
        [Column("PliValor")]
        public decimal Valor { get; set; }
    }
}
