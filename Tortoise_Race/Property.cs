using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortoise_Race
{
    public class Property
    {
        public string NotBetYet { get; set; } = " has not placed a bet.";
        public string Busted { get; set; } = " you have run out of Cash! BUSTED!";
        public string LBLJong { get; set; } = "";
        public string LBLHarman { get; set; } = "";
        public string LBLJosh { get; set; } = "";
        public RadioButton FakeRB { get; set; } = new RadioButton();

        public bool isWinner { get; set; } = false;

        public int Tortoise { get; set; }
        public int TortoiseID { get; set; }
        public int Guy { get; set; }

        //public int TortoiseWinner { get; set; }
        //public int TortoiseWinnerID { get; set; }
        public int TortoiseRaceNum { get; set; }

    }
}
