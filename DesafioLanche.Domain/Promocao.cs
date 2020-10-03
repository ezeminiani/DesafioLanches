using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("PROMOCAO")]
    public class Promocao : BaseEntity
    {
        [Column("ProLancheId")]
        public long LancheId { get; set; }

        [ForeignKey("LancheId")]
        public virtual Lanche Lanche { get; set; }

        [Required]
        [Column("ProNome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [Column("ProDescricao")]
        [MaxLength(1024)]
        public string Descricao { get; set; }

        /// <summary>
        /// O lanche promocional possuim um percentual de desconto.
        /// </summary>
        [Required]
        [Column("ProDesconto")]
        [DefaultValue(0)]
        public decimal Desconto { get; set; }

        [Required]
        [EnumDataType(typeof(PromocaoStatus))]
        [Column("ProStatus")]
        public PromocaoStatus Status { get; set; }


        /// <summary>
        /// um lanche de Promocao possui N ingredientes.
        /// </summary>
        public virtual ICollection<PromocaoXingrediente> PromocaoXingredientes { get; set; }

    }

    public enum PromocaoStatus
    {
        INATIVO,
        ATIVO
    }
}
