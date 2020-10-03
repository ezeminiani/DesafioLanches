using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("LANCHE")]
    public class Lanche : BaseEntity
    {
        [Required]
        [Column("LchNome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [Column("LchDescricao")]
        [MaxLength(1024)]
        public string Descricao { get; set; }

        [Required]
        [EnumDataType(typeof(LancheStatus))]
        [Column("LchStatus")]
        public LancheStatus Status { get; set; }

        /// <summary>
        /// true = indica que o lanche tem ingrediente fixo; false = o lanche pode ser personalizado.
        /// </summary>
        [Required]
        [Column("LchFixo")]
        public bool Fixo { get; set; }

        /// <summary>
        /// true = indica que o lanche é de promoção com seus respectivos ingredientes; false = lanche normal (fixo ou personalizado)
        /// </summary>
        [Required]
        [Column("LchEpromocao")]
        [DefaultValue(false)]
        public bool Epromocao { get; set; }
             

        /// <summary>
        /// Um lanche pode conter N ingredientes.
        /// </summary>
        public virtual ICollection<LancheXingrediente> LancheXingredientes { get; set; }

        /// <summary>
        /// Um lanche pode estar em N promocoes.
        /// </summary>
        public virtual ICollection<Promocao> Promocoes { get; set; }
    }

    public enum LancheStatus
    {
        INATIVO,
        ATIVO
    }
}
