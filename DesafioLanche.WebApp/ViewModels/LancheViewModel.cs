using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioLanche.WebApp.ViewModels
{
    public class LancheViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Lanche")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public LancheStatusViewModel Status { get; set; }

        public bool Fixo { get; set; }

        public bool Epromocao { get; set; }

        public virtual List<IngredienteViewModel> Ingredientes { get; set; }

        //public virtual List<PromocaoViewModel> Promocoes { get; set; }
    }

    public enum LancheStatusViewModel
    {
        INATIVO,
        ATIVO
    }

}