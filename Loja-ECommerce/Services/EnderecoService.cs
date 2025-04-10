using Loja_ECommerce.Entidades.Enderecos;

namespace Loja_ECommerce.Services
{
    public class EnderecoService
    {
        private List<Enderecos> listaEnderecos = new List<Enderecos>();
        private int proximoId = 1;

        public void AdicionarEndereco(int id_endereco, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            if (listaEnderecos.Exists(x => x.ID_Enderecos == id_endereco))
            {
                Console.WriteLine("Endereço ja cadastrado");
                return;
            }
            Enderecos endereco = new Enderecos(proximoId++, logradouro, numero, complemento, bairro, cidade, estado, cep);
            listaEnderecos.Add(endereco);
            Console.WriteLine("Endereço Cadastrado com sucesso!");
        }


        public void RemoverEndereco(int id)
        {
            Enderecos endereco = listaEnderecos.Find(x => x.ID_Enderecos == id);
            if (endereco != null)
            {
                listaEnderecos.Remove(endereco);
            }
            else
            {
                Console.WriteLine("Endereço não encontrado");
            }
        }

        public void ListarEnderecos()
        {
            if (listaEnderecos.Count == 0)
            {
                Console.WriteLine("Nenhum Endereço cadastrado");
                return;
            }
            foreach (Enderecos item in listaEnderecos)
            {
                item.ExibirDetalhesEnderecos();
            }
        }

        public void AlterarEndereco(int id, string novoLogradouro, string novoNumero, string novoComplemento, string novoBairro, string novaCidade, string novoEstado, string novoCep)
        {
            Enderecos endereco = listaEnderecos.Find(x => x.ID_Enderecos == id);
            if (endereco != null)
            {
                endereco.Logradouro = novoLogradouro;
                endereco.Numero = novoNumero;
                endereco.Complemento = novoComplemento;
                endereco.Bairro = novoBairro;
                endereco.Cidade = novaCidade;
                endereco.Estado = novoEstado;
                endereco.CEP = novoCep;
            }
            else
            {
                Console.WriteLine("Endereço não encontrado");
            }
        }
    }
}