using System.ComponentModel.DataAnnotations;

namespace DesafioLanche.WebApp.ViewModels
{
    public class IngredienteViewModel
    { 
        public long Id { get; set; }

        [Display(Name = "Ingrediente")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public IngredienteStatusViewModel Status { get; set; }
    }

    public enum IngredienteStatusViewModel
    {
        INATIVO,
        ATIVO
    }
}