using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_ECommerce.Entidades.Produtos;

namespace Loja_ECommerce.Services
{
    public class Loja
    {
        private List<Produto> listaProdutos = new List<Produto>();
        private int proximoId = 1;

        public void AdicionarProduto(Produto produto)
        {
            produto.ID_Produto = proximoId++;
            listaProdutos.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!");
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
    }

}
