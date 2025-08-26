namespace MinhaApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0.0m;
        public int Quantidade { get; set; } = 0;
    }
}
