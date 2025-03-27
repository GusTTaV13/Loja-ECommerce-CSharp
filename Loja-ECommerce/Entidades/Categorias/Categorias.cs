using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_ECommerce.Entidades.Categorias
{
    public class Categorias
    {
        public int ID_Categorias { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }

        public Categorias(int id_categorias, string nome, string descricao, bool ativo)
        {
            ID_Categorias = id_categorias;
            Nome = nome;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Ativo = ativo;

        }
        public void ExibirDetalhesCategorias()
        {
            Console.WriteLine($"ID: {ID_Categorias} | Nome: {Nome} | Descrição: {Descricao} | Data de Criação : {DataCriacao} | Ativo: {Ativo} |");
        }
    }
}