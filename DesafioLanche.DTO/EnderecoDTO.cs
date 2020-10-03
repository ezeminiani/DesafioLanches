using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class EnderecoDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        public virtual ClienteDTO Cliente { get; set; }

        [DataMember(Order = 2)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string TipoEndereco { get; set; }

        [DataMember(Order = 3)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(1024, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 1024 caracteres")]
        public string Logradouro { get; set; }

        [DataMember(Order = 4)]
        [StringLength(255, ErrorMessage = "campo {0} deve ter até 1024 caracteres")]
        [MaxLength(1024)]
        public string Complemento { get; set; }

        [DataMember(Order = 5)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Bairro { get; set; }

        [DataMember(Order = 6)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Cidade { get; set; }

        [DataMember(Order = 7)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "campo {0} deve ter entre 3 e 255 caracteres")]
        public string Estado { get; set; }

        [DataMember(Order = 8)]
        [Required(ErrorMessage = "campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "campo {0} deve ter entre 8 e 50 caracteres")]
        public string CEP { get; set; }

    }
}
