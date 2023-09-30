using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Passeador
    {
            public Cliente cliente;
            private string nomePasseador;
            
            public string NomePasseador
            {
                get
                {
                    return nomePasseador;
                }
                set
                {
                    if (value != null)
                    {
                        nomePasseador = value;
                    }
                    else
                    {
                        throw new Exception("Valor nulo");
                    }
                }
            }
           
        }
    }

