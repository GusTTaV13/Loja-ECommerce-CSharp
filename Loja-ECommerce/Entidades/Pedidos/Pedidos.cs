using System.Diagnostics.CodeAnalysis;

namespace Loja_ECommerce.Entidades.Pedidos
{
    public class Pedidos
    {
        public int ID_Pedido { get; set; }
        //public int ID_Usuario { get; set; }
        //public int ID_Endereco { get; set; }
        public DateTime DataPedido { get; set; }
        public required string Status { get; set; }
        public decimal Total { get; set; }

        [SetsRequiredMembers]
        public Pedidos(int id_pedido, string status, decimal total)
        {
            ID_Pedido = id_pedido;
            DataPedido = DateTime.Now;
            Status = status;
            Total = total;

        }
        public void ExibirDetalhesPedidos()
        {
            Console.WriteLine($"ID: {ID_Pedido} | Data do pedido: {DataPedido} | Status: {Status} | Total: {Total}");
        }
    }
}
