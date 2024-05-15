using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhaCores
{
    public interface IGameView
    {
        void SetController(GameController controller);
        ComboBox Camp1
        {
            get; set;
        }
        ComboBox Camp2
        {
            get; set;
        }
        ComboBox Camp3
        {
            get; set;
        }
        ComboBox Camp4
        {
            get; set;
        }
        ComboBox Camp5
        {
            get; set;
        }
        DataGridView TabelaJogador
        {
            get; set;
        }
        DataGridView TabelaResultado
        {
            get; set;
        }
    }
}
