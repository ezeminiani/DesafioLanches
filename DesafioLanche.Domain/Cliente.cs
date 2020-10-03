using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("CLIENTE")]
    public class Cliente : BaseEntity
    {
        [Required]
        [Column("CliNome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Column("CliApelido")]
        [MaxLength(255)]
        public string Apelido { get; set; }

        [Required]
        [Column("CliDtCadastro")]
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// O cliente pode ter N endereços.
        /// </summary>
        public ICollection<Endereco> Enderecos { get; set; }

        /// <summary>
        /// O cliente pode ter N pedidos.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
