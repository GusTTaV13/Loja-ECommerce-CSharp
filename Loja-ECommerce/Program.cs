using Loja_ECommerce.Services;


class Program
{
    static void Main()
    {

        //CRUD de usuarios
        UsuariosService usuariosService = new UsuariosService();

        usuariosService.AdicionarUsuario("Gustavo Silva", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");
        usuariosService.AdicionarUsuario("Matheus Gobetti", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");
        usuariosService.AdicionarUsuario("João", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        usuariosService.ListaUsuarios();

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        //CRUD de endereços

        EnderecoService enderecoService = new EnderecoService();
        enderecoService.AdicionarEndereco(1, "Avenida do Brasil", "812", "Apartamento 604", "Bairro Jardim São José", "Ribeirão Preto", "SP", "14018-127");
        enderecoService.AdicionarEndereco(2, "Rua das Flores", "345", "Casa 3", "Bairro das Rosas", "Campinas", "SP", "13045-678");
        enderecoService.AdicionarEndereco(3, "Rua Rio de Janeiro", "567", "Sala 202", "Centro", "São Paulo", "SP", "01056-789");

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        enderecoService.ListarEnderecos();

        enderecoService.AlterarEndereco(3, "Rua Rio de Janeiro", "567", "Sala 202", "Centro", "Rio de Janeiro", "RJ", "01056-789");

        enderecoService.ListarEnderecos();

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        //CRUD de produtos
        Loja loja = new Loja();


        loja.AdicionarCelular(1, "Samsung Galaxy S24", "Smartphone com tela AMOLED de 6.1\", câmera tripla e desempenho de última geração.", 4999.90m, 25, "https://exemplo.com/imagens/samsung_s24.jpg", true, "Galaxy S24", "Exynos 2400", "8GB", "128GB");
        loja.AdicionarCelular(2, "iPhone 15 Pro", "iPhone de última geração com chip A17 Pro e câmera profissional.", 8999.00m, 15, "https://exemplo.com/imagens/iphone15pro.jpg", true, "iPhone 15 Pro", "Apple A17 Pro", "8GB", "256GB");
        loja.AdicionarCelular(3, "Xiaomi 13T Pro", "Desempenho incrível com carregamento ultra-rápido e câmera Leica.", 3699.99m, 30, "https://exemplo.com/imagens/xiaomi_13t_pro.jpg", true, "13T Pro", "MediaTek Dimensity 9200+", "12GB", "512GB");

        loja.AdicionarNotebook(4, "Dell XPS 15", "Notebook premium com tela 4K, ideal para criadores de conteúdo e profissionais exigentes.", 12999.90m, 10, "https://exemplo.com/imagens/dell_xps15.jpg", true, "XPS 15 9530", "Intel Core i9-13900H", "32GB", "1TB SSD", "NVIDIA GeForce RTX 4070");
        loja.AdicionarNotebook(5, "MacBook Pro 16\"", "MacBook com chip M3 Max, ótimo desempenho e bateria de longa duração para tarefas intensas.", 19999.00m, 8, "https://exemplo.com/imagens/macbook_pro16.jpg", true, "MacBook Pro 16 M3 Max", "Apple M3 Max", "36GB", "1TB SSD", "Apple GPU 40-core");
        loja.AdicionarNotebook(6, "Acer Nitro 5", "Notebook gamer com ótimo custo-benefício e desempenho sólido para jogos.", 5899.99m, 20, "https://exemplo.com/imagens/acer_nitro5.jpg", true, "Nitro 5 AN515", "Intel Core i7-12700H", "16GB", "512GB SSD", "NVIDIA GeForce RTX 3060");

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        loja.ListarProdutos();






    } 
    }
