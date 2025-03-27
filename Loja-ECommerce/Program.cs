using Loja_ECommerce.Entidades.Produtos.ItensProduto;
using Loja_ECommerce.Entidades.Usuarios;
using Loja_ECommerce.Services;


class Program
{
    static void Main()
    {
        //Loja loja = new Loja();


        //Celular celular1 = new Celular
        //    (1, "Samsung", "Recém Lançado", 1299.99m, 1000, "https://cdn.cs.1worldsync.com/a0/50/a050a6dc-714c-4d76-be91-aeb9b02db501.jpg", true, "J2", "Exynos 3475", "1GB", "64GB");
        //Celular celular2 = new Celular
        //    (2, "Apple", "iPhone 13", 6999.99m, 500, "https://www.apple.com/v/iphone-13/d/images/overview/hero/iphone_13__f61b29gduay6_large.jpg", true, "13", "A15 Bionic", "4GB", "128GB");
        //Celular celular3 = new Celular
        //    (3, "Xiaomi", "Redmi Note 11", 1599.99m, 2000, "https://i01.appmifile.com/webp/10/04/2021/32a9cf60-cbf3-435d-a700-e7be88b6408c.jpg", true, "Note 11", "Snapdragon 680", "4GB", "64GB");
        //Celular celular4 = new Celular
        //    (4, "Motorola", "Moto G100", 3799.99m, 1500, "https://www.motorola.com.br/smartphones/moto-g100/p", true, "G100", "Snapdragon 870", "8GB", "128GB");
        //Celular celular5 = new Celular
        //    (5, "Oppo", "Oppo F19 Pro", 2499.99m, 1200, "https://static.oppo.com/content/dam/oppo/common/misc/launch-page/2021/oppo-f19pro.jpg", true, "F19 Pro", "MediaTek Helio P95", "6GB", "128GB");


        //Notebook notebook1 = new Notebook
        //    (1, "Dell", "Dell Vostro", 3000.00m, 2000, "https://tse3.mm.bing.net/th?id=OIP.h2zlpZu89Z0GY4DiF5CHDQHaHa&pid=Api", true, "Vostro 3400", "I5 1135G7", "16GB", "SSD: 256Gb HD: 512GB", "Integrado");
        //Notebook notebook2 = new Notebook
        //    (2, "HP", "HP Pavilion 15", 4500.00m, 1500, "https://www.hp.com/pt-pt/shop/media/images/pavilion-laptops/overview/Pavilion-15_03.jpg", true, "Pavilion 15", "AMD Ryzen 5 4600H", "8GB", "SSD: 512GB", "RX 7600XT 16GB");
        //Notebook notebook3 = new Notebook
        //    (3, "Lenovo", "Lenovo Ideapad 3", 3500.00m, 1800, "https://www.lenovo.com/medias/lenovo-laptop-ideapad-3-14-inch-hero.png?context=bWFzdGVyfGltYWdlc3w1NzMwMHxpbWFnZS9wbmd8aW1hZ2UvcG5nfGg5OC9oYmM4LzE4MjMwMzg4MzU0MzYwLnBuZ3xjZDhkMzBhZGM2NjMwZmYwMDhiNjkwMzg1ZGE3YjYzZTkwZGU1YjkwMjk5Zjk0Nzk0YTQwYjdhNmFkNmY1MDE5OWM", true, "Ideapad 3", "Intel Core i5-1135G7", "8GB", "SSD: 256GB", "GTX 1650 4GB");
        //Notebook notebook4 = new Notebook
        //    (4, "Acer", "Acer Aspire 5", 4000.00m, 1300, "https://www.acer.com/ac/en/US/content/series/aspire5", true, "Aspire 5", "Intel Core i7-1165G7", "16GB", "SSD: 512GB", "RTX 4060 8GB");
        //Notebook notebook5 = new Notebook
        //    (5, "Asus", "Asus VivoBook", 3800.00m, 1600, "https://www.asus.com/us/Laptops/For-Home/VivoBook/", true, "VivoBook", "Intel Core i5-1135G7", "8GB", "SSD: 512GB", "Integrado");


        //loja.AdicionarProduto(celular1);
        //loja.AdicionarProduto(celular2);
        //loja.AdicionarProduto(celular3);
        //loja.AdicionarProduto(celular4);
        //loja.AdicionarProduto(celular5);
        //loja.AdicionarProduto(notebook1);
        //loja.AdicionarProduto(notebook2);
        //loja.AdicionarProduto(notebook3);
        //loja.AdicionarProduto(notebook4);
        //loja.AdicionarProduto(notebook5);


        //loja.ListarProdutos();

        //CRUD de usuarios
        UsuariosService usuariosService = new UsuariosService();

        usuariosService.AdicionarUsuario("Gustavo Silva", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");
        usuariosService.AdicionarUsuario("Matheus Gobetti", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");
        usuariosService.AdicionarUsuario("João", "GustavoHFS@gmail.com", "12345", "16992254390", "Admin");

        usuariosService.ListaUsuarios();

        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        //CRUD de endereços

        EnderecoService enderecoService = new EnderecoService();
        enderecoService.AdicionarEndereco(1, "Avenida do Brasil", "812", "Apartamento 604", "Bairro Jardim São José", "Ribeirão Preto", "SP", "14018-127");
        enderecoService.AdicionarEndereco(2, "Rua das Flores", "345", "Casa 3", "Bairro das Rosas", "Campinas", "SP", "13045-678");
        enderecoService.AdicionarEndereco(3, "Rua Rio de Janeiro", "567", "Sala 202", "Centro", "São Paulo", "SP", "01056-789");

        enderecoService.ListarEnderecos();

        enderecoService.AlterarEndereco(3, "Rua Rio de Janeiro", "567", "Sala 202", "Centro", "Rio de Janeiro", "RJ", "01056-789");

        enderecoService.ListarEnderecos();
    }
    }
