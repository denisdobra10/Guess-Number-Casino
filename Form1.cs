using GuessNumberCasino.Scripts;

namespace GuessNumberCasino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void magicNumberTextbox_MouseEnter(object sender, EventArgs e)
        {
            magicNumberTextbox.Text = "";
        }

        private void magicNumberTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (magicNumberTextbox.Focused)
                return;

            if (magicNumberTextbox.Text.Length == 0)
                magicNumberTextbox.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int bet = int.Parse(betTextbox.Text);
            if (bet > GameManager.pocket.GetMoneyAmount())
                return;

            int magicNumber;
            if (int.TryParse(magicNumberTextbox.Text, out magicNumber) && (magicNumber > 0 && magicNumber < 10))
            {
                magicNumberLabel.Text = GameManager.RevealMagicNumber(magicNumber, bet).ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameManager.Initialize(pocketMoneyTextbox);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IncreaseBet(100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DecreaseBet(100);
        }



        private void IncreaseBet(int amount)
        {
            int bet = int.Parse(betTextbox.Text) + amount;

            if (bet > GameManager.pocket.GetMoneyAmount())
                return;

            betTextbox.Text = bet.ToString();
        }

        private void DecreaseBet(int amount)
        {
            int bet = int.Parse(betTextbox.Text) - amount;

            if (bet < 100)
                return;

            betTextbox.Text = bet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPocketMoney(50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPocketMoney(500);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPocketMoney(5000);
        }

        private void AddPocketMoney(int amount)
        {
            GameManager.pocket.AddMoney(amount);
        }
    }
}