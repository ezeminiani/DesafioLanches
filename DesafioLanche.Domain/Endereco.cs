using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("ENDERECO")]
    public class Endereco : BaseEntity
    {
        [Column("EndClienteId")]
        public long ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [Required]
        [Column("EndTipo")]
        [MaxLength(255)]
        public string TipoEndereco { get; set; }

        [Required]
        [Column("EndLogradouro")]
        [MaxLength(1024)]
        public string Logradouro { get; set; }

        [Column("EndComplemento")]
        [MaxLength(1024)]
        public string Complemento { get; set; }

        [Required]
        [Column("EndBairro")]
        [MaxLength(255)]
        public string Bairro { get; set; }

        [Required]
        [Column("EndCidade")]
        [MaxLength(255)]
        public string Cidade { get; set; }

        [Required]
        [Column("EndEstado")]
        [MaxLength(255)]
        public string Estado { get; set; }

        [Required]
        [Column("EndCep")]
        [MaxLength(50)]
        public string CEP { get; set; }

    }
}
