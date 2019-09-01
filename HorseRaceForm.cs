using HorseRace.classes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HorseRace
{
    //coding for a  main horse form
    public partial class HorseRaceForm : Form
    {

        public HorseRaceForm()
        {
            InitializeComponent();
            Start();
        }
        
        public void Start()
        {
            int Start = HorseGrey.Left;
            int RaceTrack = track.Width - HorseGrey.Right;
            // Add horse  in coding 
            Data.horse[0] = new Horse() { horsePicture = HorseGrey, raceTrackLength = RaceTrack, startPosition = Start };
            Data.horse[1] = new Horse() { horsePicture = HorseBlue, raceTrackLength = RaceTrack, startPosition = Start };
            Data.horse[2] = new Horse() { horsePicture = HorseGreen, raceTrackLength = RaceTrack, startPosition = Start };
            Data.horse[3] = new Horse() { horsePicture = HorseRed, raceTrackLength = RaceTrack, startPosition = Start };
            //add gambler in coding
            Data.gambler[0] = new Gambler() { cash = 50, label = label_better1, radioBtn = radioButton1, name = "Amrit" };
            Data.gambler[1] = new Gambler() { cash = 50, label = label_better2, radioBtn = radioButton2, name = "Nav" };
            Data.gambler[2] = new Gambler() { cash = 50, label = label_better3, radioBtn = radioButton3, name = "Jashan" };
            // Update labels for all the gambler
            Data.gambler[0].UpdateLabels();
            Data.gambler[1].UpdateLabels();
            Data.gambler[2].UpdateLabels();
        }
        //coding for a begin race
        private void BeginRace_Click(object sender, EventArgs e)
        {
            StartRace();
        }
        //coding for a start timer

        public void StartRace()
        {
            timer1.Start();
        }
        //coding for a winner
        public void DeclareWinner(int winner)
        {
            MessageBox.Show("Horse " + winner + " is the winner!");
            for (int i = 0; i < 3; i++)
            {
                Data.gambler[i].Collect(winner);
                Data.gambler[i].UpdateLabels();
                ResetHorsePositions();
                ResetBets();
            }
        }
        //coding for a reset horse positions
        public void ResetHorsePositions()
        {
            for (int i = 0; i < 4; i++)
            {
                Data.horse[i].TakeStartingPosition();
            }
        }
        //coding for a reset bets
        public void ResetBets()
        {
            for (int i = 0; i < 3; i++)
            {
                label_better1.Text = "Amrit hasn't placed any bets.";
                label_better2.Text = "Nav hasn't placed any bets.";
                label_better3.Text = "Jashan hasn't placed any bets.";
            }
        }
        // coding for place bets
        private void BtnBetsPlace_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDownBet.Value;
            int horse = (int)numericUpDownHorse.Value;
            Data.gambler[Data.gamblerToGamble].PlaceBet(amount, horse);
            Data.gambler[Data.gamblerToGamble].UpdateLabels();
        }
        // coding for a checked  radiobutton of gamble and Gambler
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.gamblerToGamble = 0;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.gamblerToGamble = 1;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data.gamblerToGamble = 2;
        }
        // coding for a Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.horse.Length; i++)
            {
                Thread.Sleep(6);
                Data.horse[Data.random.Next(0, 4)].Run();
                if (Data.horse[i].Run())
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    DeclareWinner(i + 1);
                }
            }
        }
        // coding for a exit Button
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_better1_Click(object sender, EventArgs e)
        {

        }
    }
}
