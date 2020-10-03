using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioLanche.Domain
{
    [Serializable]
    [Table("PROMOCAOxINGREDIENTE")]
    public class PromocaoXingrediente : BaseEntity
    {
        [Column("PxiPromocaoId")]
        public long PromocaoId { get; set; }

        [ForeignKey("PromocaoId")]
        public virtual Promocao Promocao { get; set; }


        [Column("PxiIngredienteId")]
        public long IngredienteId { get; set; }

        [ForeignKey("IngredienteId")]
        public virtual Ingrediente Ingrediente { get; set; }

        /// <summary>
        /// O ingrediente tem uma quantidade a ser atingida para ganhar a promoção.
        /// </summary>
        [Required]
        [Column("PxiQuantidade")]
        public int Quantidade { get; set; }


        /// <summary>
        /// true = indica que se o cliente selecionar um lanche personalizado deve conter essa quantidade de ingredientes para ganhar desconto.
        /// false = não deve conter esse ingrediente para satisfazer a promoção.
        /// </summary>
        [Required]
        [Column("PxiContem")]
        public bool Contem { get; set; }
    }
}
