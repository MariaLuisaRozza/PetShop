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
                    sadsad(n1, n2, passeadores, rotas); //criar função
                        ; break;
                case 2: break;
                case 3: break;
                default: Console.WriteLine("Digite uma opção válida!");break;
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

        static List<Passeador> ListaPasseadores()
        {
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

            foreach (Passeador s in passeadores)
            {
                Console.WriteLine(s.NomePasseador);
            }

            return passeadores;

        }

        static List<RotaPasseador> ValorRota()
        {
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

            foreach (RotaPasseador rota in rotas)
            {
                Console.WriteLine($"{rota.LocalRota} = {rota.ValorRota}");
            }

            return rotas;
        }

        static void SelecaoPasseador(int n1, int n2, List<Passeador> passeadores, List<RotaPasseador> rotas,)
        {
            switch (n1)
            {
                case 1:
                    string a = passeadores[0].NomePasseador;
                    break;
                case 2:
                    string b = passeadores[1].NomePasseador;
                    break;
                case 3:
                    string c = passeadores[2].NomePasseador;
                    break;
            }

            switch (n2)
            {
                case 1:
                    string d = rotas[0].LocalRota + " : " +  rotas[0].ValorRota.ToString();
                    break;
                case 2:
                    string e = rotas[1].LocalRota + " : " + rotas[1].ValorRota.ToString(); 
                    break;
            }
        }



    }

}