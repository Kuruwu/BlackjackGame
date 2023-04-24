namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerClass player1 = new PlayerClass();
            player1.playerSetup();
 
        }
    }
}