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
        static List<string> analise = new List<string>();
        static List<string> cor = new List<string>();
        Senha senha = new Senha();
        public List<Jogador> ListJogada
        {
            get
            {
                return jogada;
            }
        }
        public List<string> Analise
        {
            get
            {
                return analise;
            }
        }

        public void ConverteNumForColor()
        {
            cor.Clear();
            foreach (int obj in senha.Cor)
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
            //MessageBox.Show(string.Join(", ", cor));
        }
        public void GravaJogada(Jogador dados)
        {
            jogada.Add(dados);
            Jogador jogador = new Jogador();
            AnalisaJogada(dados);
            jogador.Tentativa++;
        }
        private void AnalisaJogada(Jogador dados)
        {
            analise.Clear();

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        if (dados.Cor == cor[0])
                        {
                            analise.Add("Preto");
                        }
                        else
                        {
                            analise.Add(ExisteNaSenha(dados.Cor));
                        }
                        break;
                    case 1:
                        if (dados.Cor2 == cor[1])
                        {
                            analise.Add("Preto");
                        }
                        else
                        {
                            analise.Add(ExisteNaSenha(dados.Cor2));
                        }
                        break;
                    case 2:
                        if (dados.Cor3 == cor[2])
                        {
                            analise.Add("Preto");
                        }
                        else
                        {
                            analise.Add(ExisteNaSenha(dados.Cor3));
                        }
                        break;
                    case 3:
                        if (dados.Cor4 == cor[3])
                        {
                            analise.Add("Preto");
                        }
                        else
                        {
                            analise.Add(ExisteNaSenha(dados.Cor4));
                        }
                        break;
                    default:
                        if (dados.Cor5 == cor[4])
                        {
                            analise.Add("Preto");
                        }
                        else
                        {
                            analise.Add(ExisteNaSenha(dados.Cor5));
                        }
                        break;
                }
            }
        }
        private string ExisteNaSenha(string dados)
        {
            foreach (string obj in cor)
            {
                if (obj == dados)
                {
                    return "Branco";
                }
            }
            return "Vermelho";
        }
        public bool Resultado()
        {
            int j = 0; //pontos
            for (int i = 0; i < 5; i++)
            {
                if (analise[i] == "Preto")
                {
                    j++;
                }
            }
            if (j == 5)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }
        public void Restart()
        {
            senha.Gerador();
            ConverteNumForColor();
            jogada.Clear();
            Jogador info = new Jogador();
            info.Tentativa = 0;
        }
    }
}

