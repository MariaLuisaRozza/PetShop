using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
internal class BanhoETosa

    {

        public Cliente cliente;

        private string verificacaoDomiciliar;

        private double valor;

        public static void MostrarTransporte()
        {
            Console.WriteLine(" Seu pet vai ser buscado em casa?");
            Console.WriteLine("Digite Sim ou Não.");

        }
        public string VerificacaoDomiciliar

        {
            

            get

            {

                return verificacaoDomiciliar;

            }

            set

            {

                if (value.Equals("sim") || value.Equals("não"))

                {

                    verificacaoDomiciliar = value;

                }

                else
                {
                    throw new Exception("Digite uma opção válida.");
                }

            }

        }

        public static void MostrarBanhoETosa()
        {
            Console.WriteLine("Qual opção de banho e tosa você deseja?\nDigite o número correspondente.");
            Console.WriteLine("1. Banho\n2. Tosa\n3. Banho e Tosa");

        }

        public double Valor

        {

            get

            {

                return valor;

            }

            set

            {

                if (value == 1)

                {
                    valor = 15.00;
                }
                else if (value == 2)

                {
                    valor = 10.00;
                }
                else if (value == 3)
                {
                    valor = 25.00;
                }

                else

                {

                    throw new Exception("Opção Inválida");

                }

            }

        }

    }

  

    


    }

