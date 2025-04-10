using Loja_ECommerce.Entidades.Produtos;
using Loja_ECommerce.Entidades.Produtos.ItensProduto;

namespace Loja_ECommerce.Services
{
    public class Loja
    {
        private List<Produto> listaProdutos = new List<Produto>();
        private int proximoId = 1;

        public void AdicionarCelular(int id_produto, string nome, string descricao, decimal preco, int estoque, string imagemUrl, bool ativo,
            string modelo, string processador, string memoriaRam, string armazenamento)
        {

            if (listaProdutos.Exists(x => x.ID_Produto == id_produto))
            {
                Console.WriteLine($"Celular com ID {id_produto} ja cadastrado");
                return;
            }
            Celular celular = new Celular(proximoId++, nome, descricao, preco, estoque, imagemUrl, ativo,
                modelo, processador, memoriaRam, armazenamento);
            listaProdutos.Add(celular);
            Console.WriteLine("Celular Cadastrado com sucesso!");
        }
        public void AdicionarNotebook(int id_produto, string nome, string descricao, decimal preco, int estoque, string imagemUrl, bool ativo,
    string modelo, string processador, string memoriaRam, string armazenamento, string placaDeVideo)
        {

            if (listaProdutos.Exists(x => x.ID_Produto == id_produto))
            {
                Console.WriteLine($"Notebook com ID {id_produto} ja cadastrado");
                return;
            }
            Notebook notebook = new Notebook(proximoId++, nome, descricao, preco, estoque, imagemUrl, ativo,
                modelo, processador, memoriaRam, armazenamento, placaDeVideo);
            listaProdutos.Add(notebook);
            Console.WriteLine("Notebook Cadastrado com sucesso!");
        }

        public void RemoverProduto(int id)
        {
            Produto produto = listaProdutos.Find(x => x.ID_Produto == id);
            if (produto != null)
            {
                listaProdutos.Remove(produto);
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }

        public void ListarProdutos()
        {
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
                return;
            }
            foreach (Produto item in listaProdutos)
            {
                item.ExibirDetalhes();
            }
        }
        public void AlterarCelular(int id, string novoNome, string novaDescricao, decimal novoPreco, int novoEstoque, string novaImagemUrl, bool novoAtivo,
            string novoModelo, string novoProcessador, string novaMemoriaRam, string novoArmazenamento)
        {
            Produto produto = listaProdutos.Find(x => x.ID_Produto == id);
            if (produto != null && produto is Celular celular)
            {
                //Propriedades do produto
                celular.Nome = novoNome;
                celular.Descricao = novaDescricao;
                celular.Preco = novoPreco;
                celular.Estoque = novoEstoque;
                celular.ImagemURL = novaImagemUrl;
                celular.Ativo = novoAtivo;
                //Propriedades do celular
                celular.Modelo = novoModelo;
                celular.Processador = novoProcessador;
                celular.MemoriaRAM = novaMemoriaRam;
                celular.Armazenamento = novoArmazenamento;

                Console.WriteLine("Celular alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Celular não encontrado");

            }
        }

        public void AlterarNotebook(int id, string novoNome, string novaDescricao, decimal novoPreco, int novoEstoque, string novaImagemUrl, bool novoAtivo,
    string novoModelo, string novoProcessador, string novaMemoriaRam, string novoArmazenamento, string novaPlacaDeVideo)
        {
            Produto produto = listaProdutos.Find(x => x.ID_Produto == id);
            if (produto != null && produto is Notebook notebook)
            {
                //Propriedades do produto
                notebook.Nome = novoNome;
                notebook.Descricao = novaDescricao;
                notebook.Preco = novoPreco;
                notebook.Estoque = novoEstoque;
                notebook.ImagemURL = novaImagemUrl;
                notebook.Ativo = novoAtivo;
                //Propriedades do notebook
                notebook.Modelo = novoModelo;
                notebook.Processador = novoProcessador;
                notebook.MemoriaRAM = novaMemoriaRam;
                notebook.Armazenamento = novoArmazenamento;

                Console.WriteLine("Notebook alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Notebook não encontrado");

            }
        }

    }
}

