using Loja_ECommerce.Entidades.Pedidos;

namespace Loja_ECommerce.Services
{
    public class PedidosService
    {
        private List<Pedidos> listaPedidos = new List<Pedidos>();
        private int proximoId = 1;

        public void AdicionarPedido(int id_pedido, string status, decimal total)
        {
            if (listaPedidos.Exists(x => x.ID_Pedido == id_pedido))
            {
                Console.WriteLine("Pedido ja cadastrado");
                return;
            }
            Pedidos pedido = new Pedidos(proximoId++, status, total);
            listaPedidos.Add(pedido);
            Console.WriteLine("Pedido Cadastrado com sucesso!");
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
        public void AlterarPedido(int id, string novoStatus, decimal novoTotal)
        {
            Pedidos pedido = listaPedidos.Find(x => x.ID_Pedido == id);
            if (pedido != null)
            {
                pedido.Status = novoStatus;
                pedido.Total = novoTotal;

            }
            else
            {
                Console.WriteLine("Pedido não encontrado");

            }
        }
    }

}