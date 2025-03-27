using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_ECommerce.Entidades.Categorias;
using Loja_ECommerce.Entidades.Produtos;
using Loja_ECommerce.Entidades.Usuarios;

namespace Loja_ECommerce.Services
{
    public class CategoriasService
    {
        private List<Categorias> listaCategorias = new List<Categorias>();
        private int proximoId = 1;

        public void AdicionarCategoria(Categorias categoria)
        {
            categoria.ID_Categorias = proximoId++;
            listaCategorias.Add(categoria);
            Console.WriteLine("Categoria adicionada com sucesso!");
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
