using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DesafioLanche.Domain
{
    /// <summary>
    /// Nessa classe colocar propriedades que serão comuns para todas as entidades, por exemplo o ID do registro.
    /// </summary>
    [DataContract]
    public class BaseEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public virtual long Id { get; set; }
    }
}
