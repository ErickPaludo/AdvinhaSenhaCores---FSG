using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SenhaCores
{
    public class GameModel
    {
        private static List<Jogador> jogada = new List<Jogador>();

        public List<Jogador> ListJogada
        {
            get
            {
                return jogada;
            }
        }

        static List<string> cor = new List<string>();
        Senha senha = new Senha();

        public void ConverteNumForColor()
        {
            foreach(int obj in senha.Cor)
            {
                switch (obj)
                {
                    case 1:
                        cor.Add("Vermelho");
                        break;
                    case 2:
                        cor.Add("Verde");
                        break;
                    case 3:
                        cor.Add("Amarelo");
                        break;
                    case 4:
                        cor.Add("Azul");
                        break;
                    case 5:
                        cor.Add("Branco");
                        break;
                    case 6:
                        cor.Add("Preto");
                        break;
                    case 7:
                        cor.Add("Rosa");
                        break;
                    default:
                        cor.Add("Cinza");
                        break;              
                }
            }
            MessageBox.Show(string.Join(", ", cor));
        }

        public void GravaJogada(Jogador dados)
        {
            jogada.Add(dados);
        }
    }
}
