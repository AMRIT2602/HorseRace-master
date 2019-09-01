using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace
{
    //coding for a abstract class
    abstract class Data
    {
        public static classes.Horse[] horse = new classes.Horse[4];
        public static classes.Gambler[] gambler = new classes.Gambler[3];
        public static Random random = new Random();
        public static int gamblerToGamble { get; set; }
    }
}
