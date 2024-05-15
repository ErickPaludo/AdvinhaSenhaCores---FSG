using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhaCores
{
    public class Jogador
    {
        private string cor, cor2, cor3, cor4, cor5;

        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
            }
        }
        public string Cor2
        {
            get
            {
                return cor2;
            }
            set
            {
                cor2 = value;
            }
        }
        public string Cor3
        {
            get
            {
                return cor3;
            }
            set
            {
                cor3 = value;
            }
        }
        public string Cor4
        {
            get
            {
                return cor4;
            }
            set
            {
                cor4 = value;
            }
        }
        public string Cor5
        {
            get
            {
                return cor5;
            }
            set
            {
                cor5 = value;
            }
        }

        public Jogador()
        {
        }

        public Jogador(string cor, string cor2, string cor3, string cor4, string cor5)
        {
            this.cor = cor;
            this.cor2 = cor2;
            this.cor3 = cor3;
            this.cor4 = cor4;
            this.cor5 = cor5;
        }
    }
}
