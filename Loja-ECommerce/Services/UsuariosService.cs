using Loja_ECommerce.Entidades.Usuarios;

namespace Loja_ECommerce.Services
{
    public class UsuariosService
    {
        private List<Usuarios> listaUsuarios = new List<Usuarios>();
        private int proximoId = 1;

        public void AdicionarUsuario(string nome, string email, string senha, string telefone, string tipoUsuario)
        {
            if (listaUsuarios.Exists(x => x.Email == email))
            {
                Console.WriteLine("Já há um usuario utilizando esse email");
                return;
            }
            Usuarios usuario = new Usuarios(proximoId++, nome, email, senha, telefone, tipoUsuario);
            listaUsuarios.Add(usuario);
            Console.WriteLine("Usuario adicionado com sucesso!");
        }

        public void RemoverUsuario(int id)
        {
            Usuarios usuario = listaUsuarios.Find(x => x.ID_Usuarios == id);
            if (usuario != null)
            {
                listaUsuarios.Remove(usuario);
            }
            else
            {
                Console.WriteLine("Usuario não encontrado");
            }
        }

        public void ListaUsuarios()
        {
            if (listaUsuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuario cadastrado");
                return;
            }
            foreach (Usuarios utilizador in listaUsuarios)
            {
                utilizador.ExibirDetalhesUsuario();
            }
        }

        public void AlterarUsuario(int id, string novoNome, string novoEmail, string novaSenha, string novoTelefone, string novoTipoUsuario)
        {
            Usuarios usuario = listaUsuarios.Find(x => x.ID_Usuarios == id);
            if (usuario != null)
            {
                usuario.Nome = novoNome;
                usuario.Email = novoEmail;
                usuario.Senha = novaSenha;
                usuario.Telefone = novoTelefone;
                usuario.TipoUsuario = novoTipoUsuario;
            }
            else 
            {
                Console.WriteLine("Usuario não encontrado");
                
            }
        }
    }
}
