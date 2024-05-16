using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhaCores
{
    public class GameController
    {
        IGameView usuariosView;
        GameModel usuariosModel;
        Jogador info = new Jogador();
        public GameController(IGameView usuariosView, GameModel usuariosModel)
        {
            this.usuariosView = usuariosView;
            this.usuariosModel = usuariosModel;
            usuariosView.SetController(this);
            Senha senha = new Senha();
            senha.Gerador();
            usuariosModel.ConverteNumForColor();
        }

        public void MostrarSenha()
        {
            usuariosModel.ConverteNumForColor();
        }
        public void Jogada()
        {
            if (IsNull())
            {
               usuariosModel.GravaJogada(new Jogador(usuariosView.Camp1.Text, usuariosView.Camp2.Text, usuariosView.Camp3.Text, usuariosView.Camp4.Text, usuariosView.Camp5.Text));

                usuariosView.Tentativa.Text = $"{info.Tentativa}/10";

                ClearCamp();
                MostrarJogada();
                ResultadoJogada();
            }
        }
        private void MostrarJogada()
        {
            usuariosView.TabelaJogador.Rows.Clear();
            foreach (Jogador obj in usuariosModel.ListJogada)
            {
                usuariosView.TabelaJogador.Rows.Add(obj.Cor,obj.Cor2,obj.Cor3,obj.Cor4,obj.Cor5);
            }   
        }
        private void ResultadoJogada()
        {
            usuariosView.TabelaResultado.Rows.Add(usuariosModel.Analise[0], usuariosModel.Analise[1], usuariosModel.Analise[2], usuariosModel.Analise[3], usuariosModel.Analise[4]);

            if (usuariosModel.Resultado() && info.Tentativa < 10)
            {
                EstadoView(false);
                usuariosView.Resultado.ForeColor = Color.Green;
                usuariosView.Resultado.Text = "Parabéns, você ganhou o Jogo!";
                usuariosView.Reiniciar.Enabled = true;
            }
            else if (info.Tentativa == 10)
            {
                EstadoView(false);
                usuariosView.Resultado.ForeColor = Color.Red;
                usuariosView.Resultado.Text = "Você perdeu o Jogo!";
                usuariosView.Reiniciar.Enabled = true;
            }
        }
        private void EstadoView(bool status)
        {
            usuariosView.Camp1.Enabled = status;
            usuariosView.Camp2.Enabled = status;
            usuariosView.Camp3.Enabled = status;
            usuariosView.Camp4.Enabled = status;
            usuariosView.Camp5.Enabled = status;
            usuariosView.Jogar.Enabled = status;
        }
        public void ClearCamp()
        {
            usuariosView.Camp1.SelectedIndex = -1;
            usuariosView.Camp2.SelectedIndex = -1;
            usuariosView.Camp3.SelectedIndex = -1;
            usuariosView.Camp4.SelectedIndex = -1;
            usuariosView.Camp5.SelectedIndex = -1;
        }
        public void ReiniciarGame()
        {
            ClearCamp();
            usuariosView.Resultado.Text = string.Empty;
            usuariosView.TabelaResultado.Rows.Clear();
            usuariosView.TabelaJogador.Rows.Clear();
            EstadoView(true);
            usuariosView.Reiniciar.Enabled = false;
            usuariosView.Tentativa.Text = "0/10";
            usuariosModel.Restart();
        }
        private bool IsNull()
        {
            if (!string.IsNullOrEmpty(usuariosView.Camp1.Text) && !string.IsNullOrEmpty(usuariosView.Camp2.Text) && !string.IsNullOrEmpty(usuariosView.Camp3.Text) && !string.IsNullOrEmpty(usuariosView.Camp4.Text) && !string.IsNullOrEmpty(usuariosView.Camp5.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RecarregarDados(int index)
        {
            try
            {
                usuariosView.Camp1.Text = usuariosModel.ListJogada[index].Cor;
                usuariosView.Camp2.Text = usuariosModel.ListJogada[index].Cor2;
                usuariosView.Camp3.Text = usuariosModel.ListJogada[index].Cor3;
                usuariosView.Camp4.Text = usuariosModel.ListJogada[index].Cor4;
                usuariosView.Camp5.Text = usuariosModel.ListJogada[index].Cor5;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
