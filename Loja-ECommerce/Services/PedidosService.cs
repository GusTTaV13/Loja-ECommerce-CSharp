using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_ECommerce.Entidades.Pedidos;
using Loja_ECommerce.Entidades.Produtos;

namespace Loja_ECommerce.Services
{
    public class PedidosService
    {
        private List<Pedidos> listaPedidos = new List<Pedidos>();
        private int proximoId = 1;

        public void AdicionarPedido(Pedidos pedido)
        {
            pedido.ID_Pedido = proximoId++;
            listaPedidos.Add(pedido);
            Console.WriteLine("Pedido adicionado com sucesso!");
        }

        public void RemoverPedido(int id)
        {
            Pedidos pedido = listaPedidos.Find(x => x.ID_Pedido == id);
            if (pedido != null)
            {
                listaPedidos.Remove(pedido);
            }
            else
            {
                Console.WriteLine("Pedido não encontrado");
            }
        }

        public void ListarPedidos()
        {
            if (listaPedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido cadastrado");
                return;
            }
            foreach (Pedidos item in listaPedidos)
            {
                item.ExibirDetalhesPedidos();
            }
        }
    }

}