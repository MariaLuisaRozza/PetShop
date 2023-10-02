namespace petshop
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("──────▄▀▄─────▄▀▄\r\n─────▄█░░▀▀▀▀▀░░█▄\r\n─▄▄──█░░░░░░░░░░░█──▄▄\r\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█\n┌────────────────────────────┐\r\n  Bem vindo ao PetShop MaRiLu \r\n└────────────────────────────┘");

            Console.WriteLine("No que podemos ajudá-lo:\n1.Cadastro Cliente\n2. Serviços PetShop");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
               Cadastro();
            } else if (num != 1 && num != 2)
            {
                throw new Exception("Opção Inválida!");
            }        
             
            Console.WriteLine("No que podemos ajudá-lo:\n1.Serviço de Passeio\n2.Banho e tosa\n3.Compra de produtos");
            int sumario = int.Parse(Console.ReadLine()!);
            
            switch (sumario)
            {
                case 1:
                    List<Passeador> passeadores = ListaPasseadores();
                    int n1 = Convert.ToInt32(Console.ReadLine()!);
                    List<RotaPasseador> rotas = ValorRota();
                    int n2 = Convert.ToInt32(Console.ReadLine()!);
                    SelecaoPasseador(n1, n2, passeadores, rotas);
                    ; break;
                case 2:
                    Banho();
                    break;
                case 3:
                    ListaProduto();
                    break;
                default: 
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }
        }

        static void Cadastro()
        {
            Cliente cliente1 = new Cliente();
            Console.WriteLine("Nome:");
            string? nome = Console.ReadLine();
            cliente1.Nome = nome!;

            Console.WriteLine("Nome do animal:");
            string? nomepet = Console.ReadLine();
            cliente1.Cachorro = nomepet!;

            Console.WriteLine("Contato:");
            string? contato = Console.ReadLine();
            cliente1.Telefone = contato!;

        }

        static void Banho()
        {
            Console.Clear();
            BanhoETosa b = new BanhoETosa();
            BanhoETosa.MostrarTransporte();
            b.VerificacaoDomiciliar = Console.ReadLine().ToLower();
            

            BanhoETosa.MostrarBanhoETosa();
            int auxiliar= int.Parse(Console.ReadLine());
            b.Valor = auxiliar;
            Console.WriteLine($"O animal vai ser buscado em casa? {b.VerificacaoDomiciliar}");
            
            switch (auxiliar )
            {
                case 1: Console.WriteLine($"Somente Banho: R$ { b.Valor}"); break;
                case 2: Console.WriteLine($"Somente Tosa: R$ {b.Valor}"); break;
                case 3: Console.WriteLine($"Banho e Tosa: R$ {b.Valor}"); break;
                default: Console.WriteLine("Digite uma opção válida!"); break;

            }
        }

        static List<Cliente> ListaDeClientes()

        {

            Cliente cliente1 = new Cliente();

            cliente1.Nome = "Jonas";

            cliente1.Cachorro = "Zeus";

            cliente1.Telefone = "3354-2546";

            Cliente cliente2 = new Cliente();

            cliente2.Nome = "Joanderson";

            cliente2.Cachorro = "Bituca";

            cliente2.Telefone = "3345-5451";

            Cliente cliente3 = new Cliente();

            cliente3.Nome = "Jesus";

            cliente3.Cachorro = "Cristo";

            cliente3.Telefone = "3456-2123";







            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(cliente1);

            clientes.Add(cliente2);

            clientes.Add(cliente3);





            foreach (Cliente cliente in clientes)

            {

                Console.WriteLine(cliente.Nome);

            }





            return clientes;
        }





            static List<Passeador> ListaPasseadores()
        {
            Console.Clear();
            Console.WriteLine(" Escolha o passeador: ");
            Passeador p1 = new Passeador();
            p1.NomePasseador = "Ricardo";
            Passeador p2 = new Passeador();
            p2.NomePasseador = "Luciano";
            Passeador p3 = new Passeador();
            p3.NomePasseador = "Maria";

            List<Passeador> passeadores = new List<Passeador>();
            passeadores.Add(p1);
            passeadores.Add(p2);
            passeadores.Add(p3);
            int i = 0;
            foreach (Passeador s in passeadores)
            {
        
                i++;
                Console.WriteLine(i + "." + s.NomePasseador);
            }

            return passeadores;

        }

        static List<RotaPasseador> ValorRota()
        {
            Console.Clear();
            Console.WriteLine(" Escolha a rota de passeio: ");
            RotaPasseador loc1 = new RotaPasseador();
            loc1.LocalRota = "Parque";
            loc1.ValorRota = 5.0;
            RotaPasseador loc2 = new RotaPasseador();
            loc2.LocalRota = "Shopping";
            loc2.ValorRota = 10.0;
            RotaPasseador loc3 = new RotaPasseador();
            loc3.LocalRota = "Campo de Treinamento";
            loc3.ValorRota = 25.50;

            List<RotaPasseador> rotas = new List<RotaPasseador>(); 
            rotas.Add(loc1);
            rotas.Add(loc2);
            rotas.Add(loc3);
            int i = 0;
            foreach (RotaPasseador rota in rotas)
            {
                
                i++;
                Console.WriteLine($"{i}.{rota.LocalRota} = R$ {rota.ValorRota} ");
            }

            return rotas;
        }

        static void SelecaoPasseador(int n1, int n2, List<Passeador> passeadores, List<RotaPasseador> rotas)
        {
            Console.Clear();

            string a = "";
            string b = "";
            switch (n1)
            {
                case 1:
                    a = passeadores[0].NomePasseador;
                    break;
                case 2:
                    a = passeadores[1].NomePasseador;
                    break;
                case 3:
                    a = passeadores[2].NomePasseador;
                    break;
            }

            switch (n2)
            {
                case 1:
                    b = rotas[0].LocalRota + " : R$" +  rotas[0].ValorRota.ToString();
                    break;
                case 2:
                    b = rotas[1].LocalRota + " : R$" + rotas[1].ValorRota.ToString(); 
                    break;
                case 3: 
                    b = rotas[2].LocalRota + " : R$" + rotas[2].ValorRota.ToString();
                    break;

            }

            Console.WriteLine($"{a}\n{b}");
        }

        public static List<Produto> ListaProduto()
        {
            Produto p1 = new Produto();
            p1.Nome = "Coleira";
            Produto p2 = new Produto();
            p2.Nome = "Roupa";
            Produto p3 = new Produto();
            p3.Nome = "Brinquedo";
            Produto p4 = new Produto();
            p4.Nome = "Produto Higienico";
            Produto p5 = new Produto();
            p5.Nome = "Tigela";
            Produto p6 = new Produto();
            p6.Nome = "Caminha";
            Produto p7 = new Produto();
            p7.Nome = "Produto médico";



            Console.ReadLine();



            List<Produto> produtos = new List<Produto>();
            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);
            produtos.Add(p5);
            produtos.Add(p6);
            produtos.Add(p7);



            foreach (Produto s in produtos)
            {
                Console.WriteLine(s.Nome);
            }



            return produtos;





        }



    }

}