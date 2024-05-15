

namespace SenhaCores
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           GameView gameView = new GameView();
            gameView.Visible = false;
            GameModel gameModel = new GameModel();
            GameController gameControler = new GameController(gameView, gameModel);
            gameView.ShowDialog();

        }
    }
}