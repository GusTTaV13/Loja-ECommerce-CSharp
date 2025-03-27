using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_ECommerce.Entidades.ItensPedido
{
    public class ItensPedido
    {
        public int ID_ItensPedido { get; set; }
        //public int ID_Pedido { get; set; }
        //public int ID_Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }



        public ItensPedido(int id_itensPedido, int quantidade, decimal total, decimal subTotal)
        {
            ID_ItensPedido = id_itensPedido;
            Quantidade = quantidade;
            Total = total;
            SubTotal = subTotal;

        }
        public void ExibirDetalhesItensPedido()
        {
            Console.WriteLine($"ID: {ID_ItensPedido} | Quantidade: {Quantidade} | Total: {Total} | SubTotal: {SubTotal} |");
        }
    }
}
