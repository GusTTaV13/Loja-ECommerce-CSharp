namespace Loja_ECommerce.Entidades.Produtos.ItensProduto
{
    internal class Notebook : Produto
    {
        public string Modelo { get; set; }
        public string Processador { get; set; }
        public string MemoriaRAM { get; set; }
        public string Armazenamento { get; set; }
        public string PlacaDeVideo { get; set; }
        public Notebook(int id_produto, string nome, string descricao, decimal preco, int estoque, string imagemUrl, bool ativo,
            string modelo, string processador, string memoriaRam, string armazenamento, string placaDeVideo)
            : base(id_produto, nome, descricao, preco, estoque, imagemUrl, ativo)
        {
            Modelo = modelo;
            Processador = processador;
            MemoriaRAM = memoriaRam;
            Armazenamento = armazenamento;
            PlacaDeVideo = placaDeVideo;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID_Produto} | Nome: {Nome} | Modelo: {Modelo} | Processador: {Processador} | MemoriaRAM: {MemoriaRAM} | " +
                              $"Armazenamento: {Armazenamento} | PlacaDeVideo: {PlacaDeVideo}");
        }
    }
}