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

        public GameController(IGameView usuariosView, GameModel usuariosModel)
        {
            this.usuariosView = usuariosView;
            this.usuariosModel = usuariosModel;
            usuariosView.SetController(this);
            Senha senha = new Senha();
            senha.Gerador();
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
                ClearCamp();
                MostrarJogada();
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

        public void ClearCamp()
        {
            usuariosView.Camp1.Text = string.Empty;
            usuariosView.Camp2.Text = string.Empty;
            usuariosView.Camp3.Text = string.Empty;
            usuariosView.Camp4.Text = string.Empty;
            usuariosView.Camp5.Text = string.Empty;
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
    }
}
