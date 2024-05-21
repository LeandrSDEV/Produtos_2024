namespace Produtos_2024.Models
{
    public class ProdutoModel
    {
        public Int64 ? Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string CodigoDeBarras { get; set; } = string.Empty;
        public DateTime DataDeValidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public int Quantidade { get; set; }
        public Decimal? Valor { get; set; }
        public string NomeDaFoto { get; set; }
        public byte[] Foto { get; set; }
        public bool Ativo { get; set; }

    }
}
