using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Produto
    {
        private string nome;
        private double valor;
        private string marca;

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
            }
        }
        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value != null)
                {
                    valor = value;
                }
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                if (value != null)
                {
                    marca = value;
                }
            }
        }
    }
}
