using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_ECommerce.Entidades.Produtos;

namespace Loja_ECommerce.Entidades.Produtos.ItensProduto
{
    public class Celular : Produto
    {
        public string Modelo { get; set; }
        public string Processador { get; set; }
        public string MemoriaRAM { get; set; }
        public string Armazenamento { get; set; }

        public Celular(int id_produto, string nome, string descricao, decimal preco, int estoque, string imagemUrl, bool ativo,
            string modelo, string processador, string memoriaRam, string armazenamento)
            : base(id_produto, nome, descricao, preco, estoque, imagemUrl, ativo)
        {
            Modelo = modelo;
            Processador = processador;
            MemoriaRAM = memoriaRam;
            Armazenamento = armazenamento;

        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID_Produto} | Nome: {Nome} | Modelo: {Modelo} | Processador: {Processador} | MemoriaRAM: {MemoriaRAM} | Armazenamento: {Armazenamento}0");
        }
    }
}
