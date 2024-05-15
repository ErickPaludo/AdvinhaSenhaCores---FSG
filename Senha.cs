using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhaCores
{
    public class Senha : ICommand
    {
        private GameModel modelo;
        private string novaSenha;
        static private List<int> cor = new List<int>();
        public List<int> Cor
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

        public Senha()
        {
        }

        public Senha(GameModel modelo, string novaSenha)
        {
            this.modelo = modelo;
            this.novaSenha = novaSenha;
        }

        public void Gerador()
        {
            cor.Clear();
            Random r = new Random();
            cor.Add(r.Next(1, 9)); // Adiciona o primeiro número aleatório à lista

            do
            {
                int n = r.Next(1, 9); // Gera um novo número aleatório

                // Verifica se o número já existe na lista
                bool validador = true; // Reinicia o validador para true antes de verificar o próximo número
                foreach (int i in cor)
                {
                    if (i == n)
                    {
                        validador = false;
                        break;
                    }
                }
                if (validador)
                {
                    cor.Add(n);
                }

            } while (cor.Count < 5);

       //Mostra os numeros gerados
       //     MessageBox.Show(string.Join(", ", cor));
        }

    }
}
