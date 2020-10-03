using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("LANCHExINGREDIENTE")]
    public class LancheXingrediente : BaseEntity
    {
        [Column("LxiLancheId")]
        public long LancheId { get; set; }

        [ForeignKey("LancheId")]
        public virtual Lanche Lanche { get; set; }


        [Column("LxiIngredienteId")]
        public long IngredienteId { get; set; }

        [ForeignKey("IngredienteId")]
        public virtual Ingrediente Ingrediente { get; set; }
    }
}
