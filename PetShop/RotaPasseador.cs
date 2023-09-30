using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class RotaPasseador
    {
        private string localRota;
        private double valorRota;

        public string LocalRota
        {
            get
            {
                return localRota;
            }
            set
            {
                if (value != null)
                {
                    localRota = value;
                }
                else
                {
                    throw new Exception("Valor nulo");
                }
            }
        }
        public double ValorRota
        {
            get
            {
                return valorRota;
            }
            set
            {
                if (value > 0)
                {
                    valorRota = value;
                }
                else
                {
                    throw new Exception("Valor nulo");
                }
            }
        }

    }
}
