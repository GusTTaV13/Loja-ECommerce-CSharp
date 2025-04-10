namespace Loja_ECommerce.Entidades.Produtos
{
    public abstract class Produto
    {
        public int ID_Produto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string ImagemURL { get; set; }
        public bool Ativo { get; set; }

        public Produto(int id_produto, string nome, string descricao, decimal preco, int estoque, string imagemUrl, bool ativo)
        {
            ID_Produto = id_produto;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            ImagemURL = imagemUrl;
            Ativo = ativo;

        }

        public abstract void ExibirDetalhes();
    }
}
