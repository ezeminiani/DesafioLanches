using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("INGREDIENTE")]
    public class Ingrediente : BaseEntity
    {
        [Required]
        [Column("IngNome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [Column("IngDescricao")]
        [MaxLength(1024)]
        public string Descricao { get; set; }

        [Required]
        [Column("IngPreco")]
        public decimal Preco { get; set; }

        [Required]
        [EnumDataType(typeof(IngredienteStatus))]
        [Column("IngStatus")]
        public IngredienteStatus Status { get; set; }

        /// <summary>
        /// O ingrediente por estar em N lanches.
        /// </summary>
        public virtual ICollection<LancheXingrediente> LancheXingredientes { get; set; }

    }


    public enum IngredienteStatus
    {
        INATIVO,
        ATIVO
    }
}
