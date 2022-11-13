using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberCasino.Scripts
{
    public class Pocket
    {
        public TextBox moneyTextbox = new TextBox();

        private int money;


        public Pocket(int amount)
        {
            this.money = amount;
        }


        public int GetMoneyAmount() { return money; }

        public void AddMoney(int amount)
        {
            this.money += amount;

            moneyTextbox.Text = money.ToString();
        }

        public void SubstractMoney(int amount)
        {
            this.money -= amount;

            moneyTextbox.Text = money.ToString();
        }

    }
}
