using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRace.classes
{
    //coding for a Horse class
    public class Horse
    {
        public int startPosition { get; set; }
        public int raceTrackLength { get; set; }
        public PictureBox horsePicture { get; set; }
        public int location;
        private Random randomizer = new Random();
        // coding for run a horse
        public bool Run()
        {
            int moveForward = randomizer.Next(1, 6);
            location = location + moveForward;
            horsePicture.Left = startPosition + location;

            if (horsePicture.Left >= raceTrackLength)
                return true;
            else
                return false;
        }
        //coding for a starting position
        public void TakeStartingPosition()
        {
            location = 0;
            horsePicture.Left = startPosition;
        }
    }
}
