namespace DesafioLanche.WebApp.ViewModels
{
    public class PromocaoXingredienteViewModel
    {
        public long Id { get; set; }
        
        public IngredienteViewModel Ingrediente { get; set; }

        public int Quantidade { get; set; }

        public bool Contem { get; set; }
    }
}