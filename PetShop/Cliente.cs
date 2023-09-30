using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Cliente
    {
        private string nome;
        private string cachorro;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != null)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Valor nulo");
                }

            }
        }
        public string Cachorro
        {
            get
            {
                return cachorro;
            }
            set
            {
                if (value != null)
                {
                    cachorro = value;
                }
                else
                {
                    throw new Exception("Valor nulo");
                }

            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value != null)
                {
                    telefone = value;
                }
                else
                {
                    throw new Exception("Valor nulo");
                }

            }
        }




    }
}

