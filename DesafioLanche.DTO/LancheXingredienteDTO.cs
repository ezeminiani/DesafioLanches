using System.Runtime.Serialization;

namespace DesafioLanche.DTO
{
    [DataContract]
    public class LancheXingredienteDTO
    {
        [DataMember(Order = 0)]
        public long Id { get; set; }

        [DataMember(Order = 1)]
        public virtual LancheDTO Lanche { get; set; }

        [DataMember(Order = 2)]
        public virtual IngredienteDTO Ingrediente { get; set; }
    }
}
