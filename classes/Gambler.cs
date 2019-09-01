using System.Windows.Forms;

namespace HorseRace.classes
{
    //coding for a Gambler 
    public class Gambler
    {
        public string name { get; set; }
        public int cash { get; set; }
        public RadioButton radioBtn { get; set; }
        public Label label { get; set; }
        public int amount { get; set; }
        public Gamble gamble = new Gamble();
            // coding for a UpdateLabels
        public void UpdateLabels()
        {
            gamble.gambler = this;
            label.Text = gamble.GetDescription();
            radioBtn.Text = name + " has " + cash + " bucks.";
        }
        //coding for a PlaceBet

        public bool PlaceBet(int amount, int horse)
        {
            if (amount <= cash)
            {
                gamble.amount += amount;
                cash -= amount;
                gamble.horse = horse;
                return true;
            }
            else
            {
                MessageBox.Show(name + " does not have enough cash!");
                return false;
            }
        }
        //coding for a collect

        public void Collect(int winner)
        {
            gamble.Payout(winner);
        }
    }
}
