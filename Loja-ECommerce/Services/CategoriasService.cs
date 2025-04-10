using Loja_ECommerce.Entidades.Categorias;

namespace Loja_ECommerce.Services
{
    public class CategoriasService
    {
        private List<Categorias> listaCategorias = new List<Categorias>();
        private int proximoId = 1;

        public void AdicionarCategoria(int id_categoria, string nome, string descricao, bool ativo)
        {
            if (listaCategorias.Exists(x => x.ID_Categorias == id_categoria))
            {
                Console.WriteLine("Categoria ja cadastrada");
                return;
            }
            Categorias categoria = new Categorias(proximoId++, nome, descricao, ativo);
            listaCategorias.Add(categoria);
            Console.WriteLine("Categoria Cadastrada com sucesso!");
        }

        public void RemoverCategoria(int id)
        {
            Categorias categoria = listaCategorias.Find(x => x.ID_Categorias == id);
            if (categoria != null)
            {
                listaCategorias.Remove(categoria);
            }
            else
            {
                Console.WriteLine("Categoria não encontrada");
            }
        }

        public void ListarCategorias()
        {
            if (listaCategorias.Count == 0)
            {
                Console.WriteLine("Nenhuma Categoria cadastrada");
                return;
            }
            foreach (Categorias item in listaCategorias)
            {
                item.ExibirDetalhesCategorias();
            }
        }

        public void AlterarCategoria(int id, string novoNome, string novaDescricao, bool novoAtivo)
        {
            Categorias categorias = listaCategorias.Find(x => x.ID_Categorias == id);
            if (categorias != null)
            {
                categorias.Nome = novoNome;
                categorias.Descricao = novaDescricao;
                categorias.Ativo = novoAtivo;

            }
            else
            {
                Console.WriteLine("Categoria não encontrado");

            }
        }
    }
}
