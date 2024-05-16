namespace SenhaCores
{
    public partial class GameView : Form, IGameView
    {
        GameController controller;
        public GameView()
        {
            InitializeComponent();
        }
        public ComboBox Camp1
        {
            get
            {
                return comboCamp;
            }
            set
            {
                comboCamp = value;
            }
        }
        public ComboBox Camp2
        {
            get
            {
                return comboCamp2;
            }
            set
            {
                comboCamp2 = value;
            }
        }
        public ComboBox Camp3
        {
            get
            {
                return comboCamp3;
            }
            set
            {
                comboCamp3 = value;
            }
        }
        public ComboBox Camp4
        {
            get
            {
                return comboCamp4;
            }
            set
            {
                comboCamp4 = value;
            }
        }
        public ComboBox Camp5
        {
            get
            {
                return comboCamp5;
            }
            set
            {
                comboCamp5 = value;
            }
        }
        public DataGridView TabelaJogador
        {
            get
            {
                return dataGridJogada;
            }
            set
            {
                dataGridJogada = value;
            }
        }
        public DataGridView TabelaResultado
        {
            get
            {
                return dataGridResultado;
            }
            set
            {
                dataGridResultado = value;
            }
        }
        public Label Tentativa
        {
            get
            {
                return lTentativas;
            }
            set
            {
                lTentativas = value;
            }
        }

        public void SetController(GameController controller)
        {
            this.controller = controller;
        }

        private void Play(object sender, EventArgs e)
        {
           // controller.Jogada();
           controller.Jogada();
        }
    }
}
