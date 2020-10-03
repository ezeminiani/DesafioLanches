using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("PEDIDO")]
    public class Pedido : BaseEntity
    {
        [Column("PedClienteId")]
        public long ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [Required]
        [Column("PedDtEmissao")]
        public DateTime DataEmissao { get; set; }

        [Required]
        [Column("PedSubTotal")]
        public decimal SubTotal { get; set; }

        [Required]
        [Column("PedDescontoTotal")]
        public decimal DescontoTotal { get; set; }

        [Required]
        [Column("PedTotal")]
        public decimal Total { get; set; }


        /// <summary>
        /// Um pedido contem N lanches com N ingredientes.
        /// </summary>
        public ICollection<PedidoXlancheXingrediente> PedidoXlancheXingredientes { get; set; }
    }
}
