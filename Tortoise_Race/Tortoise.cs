using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortoise_Race
{

    public abstract class Tortoise
    {
        public int TortoiseID { get; set; }
        public string Name { get; set; }
        public PictureBox MyPictureBox { get; set; }

        private int newDistance = 76;


        public void UpdatePostition()
        {
            //moves the picture box to new postion
            MyPictureBox.Left = newDistance;
        }
        public void StartingPostition()
        {
            // new distance of the tortoise
            newDistance = 76;
            // current location
            var location = MyPictureBox.Location;
            // changes the current location to new location
            location.X = newDistance;
            //moves the picture box
            MyPictureBox.Location = location;
            //updates the postion
            UpdatePostition();
        }
        public void Run()
        {
            //new distance + random move of 1, 2, 3, or 4 spaces
            newDistance += Factory.Number();
            //updates the postion
            UpdatePostition();
        }
    }

    class Tortoise01 : Tortoise
    {
        public Tortoise01()
        {
            TortoiseID = 1;
            Name = "Shell Shock";
        }
    }

    class Tortoise02 : Tortoise
    {

        public Tortoise02()
        {
            TortoiseID = 2;
            Name = "Sally Monella";
        }
    }

    class Tortoise03 : Tortoise
    {
        public Tortoise03()
        {
            TortoiseID = 3;
            Name = "Voldetort";
        }
    }

    class Tortoise04 : Tortoise
    {
        public Tortoise04()
        {
            TortoiseID = 4;
            Name = "MiShell";
        }
    }

}
