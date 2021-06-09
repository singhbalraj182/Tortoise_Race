using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortoise_Race
{
    public abstract class Punter
    {
        public int GuyID { get; set; }
        public string GuyName { get; set; }
        public int MaxCash { get; set; }
        public int AmountBet { get; set; }
        public int BettorTortoiseNum { get; set; }
        public RadioButton MyRadioButton { get; set; }
    }

    public class Guy01 : Punter
    {
        public Guy01()
        {
            GuyID = 1;
            GuyName = "Jong";
            MaxCash = 50;
        }
    }

    class Guy02 : Punter
    {
        public Guy02()
        {
            GuyID = 2;
            GuyName = "Harman";
            MaxCash = 50;
        }
    }

    class Guy03 : Punter
    {
        public Guy03()
        {
            GuyID = 3;
            GuyName = "Josh";
            MaxCash = 50;
        }
    }
}
