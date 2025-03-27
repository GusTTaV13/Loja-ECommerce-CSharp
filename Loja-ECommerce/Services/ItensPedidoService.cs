using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_ECommerce.Entidades.Categorias;
using Loja_ECommerce.Entidades.ItensPedido;
using Loja_ECommerce.Entidades.Produtos;

namespace Loja_ECommerce.Services
{
    public class ItensPedidoService
    {
      
        private List<ItensPedido> listaItensPedidos = new List<ItensPedido>();
        private int proximoId = 1;

        public void AdicionarItensPedido(ItensPedido itenPedido)
        {
            itenPedido.ID_ItensPedido = proximoId++;
            listaItensPedidos.Add(itenPedido);
            Console.WriteLine("Item Pedido adicionado com sucesso!");
        }

        public void RemoverItemPedido(int id)
        {
            ItensPedido itenPedido = listaItensPedidos.Find(x => x.ID_ItensPedido == id);
            if (itenPedido != null)
            {
                listaItensPedidos.Remove(itenPedido);
            }
            else
            {
                Console.WriteLine("Item Pedido não encontrada");
            }
        }
        public void ListarItensPedidos()
        {
            if (listaItensPedidos.Count == 0)
            {
                Console.WriteLine("Nenhum Item Pedido cadastrado");
                return;
            }
            foreach (ItensPedido item in listaItensPedidos)
            {
                item.ExibirDetalhesItensPedido();
            }
        }
    }

}
