using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberCasino.Scripts
{
    public static class GameManager
    {
        public static Pocket pocket = new(100);

        private static int magicNumber;


        public static void Initialize(TextBox pocketMoneyTextbox)
        {
            magicNumber = 0;

            // Set pocket properties
            pocket = new Pocket(100);
            pocket.moneyTextbox = pocketMoneyTextbox;
            pocket.moneyTextbox.Text = pocket.GetMoneyAmount().ToString();
        }


        public static int RevealMagicNumber(int userNumber, int bet)
        {
            magicNumber = new Random().Next(1, 10);

            if(userNumber == magicNumber)
            {
                pocket.AddMoney(bet * 10);
                MessageBox.Show("CONGRATULATIONS!!! YOU WON " + bet * 10);

            }
            else
            {
                pocket.SubstractMoney(bet);
                MessageBox.Show("Maybe next time! Magic number was: " + magicNumber);
                
            }

            return magicNumber;

        }

    }
}
