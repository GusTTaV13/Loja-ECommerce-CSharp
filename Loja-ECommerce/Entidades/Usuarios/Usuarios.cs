namespace Loja_ECommerce.Entidades.Usuarios
{
    public class Usuarios
    {
        public int ID_Usuarios { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCriacao { get; set; }
        public string TipoUsuario { get; set; }


        public Usuarios(int id_usuarios, string nome, string email, string senha, string telefone, string tipoUsuario)
        {
            ID_Usuarios = id_usuarios;
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            DataCriacao = DateTime.Now;
            TipoUsuario = tipoUsuario;

        }
        public void ExibirDetalhesUsuario()
        {
            Console.WriteLine($"ID: {ID_Usuarios} | Nome: {Nome} | Email: {Email} | Senha: {Senha} | Telefone: {Telefone} | DataCriacao: {DataCriacao} | TipoUsuario: {TipoUsuario}");
        }
    }
}
