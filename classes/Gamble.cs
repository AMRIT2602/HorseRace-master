using System.Windows.Forms;

namespace HorseRace.classes
{    // coding for Gamble class
    public class Gamble
    {
        public int amount { get; set; }
        public int horse { get; set; }
        public Gambler gambler { get; set; }
        // coding for description of amount
        public string GetDescription()
        {
           if (amount == 0)
            {
                return gambler.name + " hasn't placed a bet.";
            }
           else
            {
                return gambler.name + " bets " + amount + " on horse " + horse;
            }

        }
        // coding for payout winner in Gamble class

        public int Payout(int winner)
        {
            if (horse == winner)
            {
                int Amount = amount;
                MessageBox.Show(gambler.name + " takes the money!");
                ClearBet();
                return gambler.cash += Amount * 2;
            }
            else
            {
                ClearBet();
                return 0;
            }
        }

        public void ClearBet()
        {
            amount = 0;
        }
    }
}
