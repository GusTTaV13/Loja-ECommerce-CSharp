using Loja_ECommerce.Entidades.ItensPedido;

namespace Loja_ECommerce.Services
{
    public class ItensPedidoService
    {

        private List<ItensPedido> listaItensPedidos = new List<ItensPedido>();
        private int proximoId = 1;

        public void AdicionarItemPedido(int id_itensPedido, int quantidade, decimal total, decimal subTotal)
        {
            if (listaItensPedidos.Exists(x => x.ID_ItensPedido ==  id_itensPedido))
            {
                Console.WriteLine("Item Pedido ja cadastrado");
                return;
            }
            ItensPedido itemPedido = new ItensPedido(proximoId++, quantidade, total, subTotal);
            listaItensPedidos.Add(itemPedido);
            Console.WriteLine("Item do pedido Cadastrado com sucesso!");
        }

        public void RemoverItemPedido(int id)
        {
            ItensPedido itemPedido = listaItensPedidos.Find(x => x.ID_ItensPedido == id);
            if (itemPedido != null)
            {
                listaItensPedidos.Remove(itemPedido);
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

        public void AlterarItensPedido(int id, int novaQuantidade, decimal novoTotal, decimal novoSubTotal)
        {
            ItensPedido itensPedido = listaItensPedidos.Find(x => x.ID_ItensPedido == id);
            if (itensPedido != null)
            {
                itensPedido.Quantidade = novaQuantidade;
                itensPedido.Total = novoTotal;
                itensPedido.SubTotal = novoSubTotal;
            }
            else
            {
                Console.WriteLine("Item Pedido não encontrado");
            }
        }
    }
}
