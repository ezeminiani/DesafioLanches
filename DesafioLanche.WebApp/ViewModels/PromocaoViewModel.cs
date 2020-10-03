using System.Collections.Generic;

namespace DesafioLanche.WebApp.ViewModels
{
    public class PromocaoViewModel
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Desconto { get; set; }

        public PromocaoStatusViewModel Status { get; set; }

        public virtual List<PromocaoXingredienteViewModel> Ingredientes { get; set; }

    }

    public enum PromocaoStatusViewModel
    {
        INATIVO,
        ATIVO
    }
}