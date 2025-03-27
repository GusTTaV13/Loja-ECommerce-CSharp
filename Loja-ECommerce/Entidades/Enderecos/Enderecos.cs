using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_ECommerce.Entidades.Enderecos
{
    public class Enderecos
    {
        public int ID_Enderecos { get; set; }
        //public int ID_Usuarios { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }


        public Enderecos(int id_enderecos, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            ID_Enderecos = id_enderecos;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;

        }
        public void ExibirDetalhesEnderecos()
        {
            Console.WriteLine($"ID: {ID_Enderecos} | Logradouro: {Logradouro} | Numero: {Numero} | Complemento: {Complemento} | Bairro: {Bairro} | Cidade: {Cidade} | Estado: {Estado}| CEP: {CEP}");
        }
    }
}
