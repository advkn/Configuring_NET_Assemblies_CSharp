using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }

        //accept the base class's param values
        public SportsCar(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }

        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!", "Faster is better...");
        }
    }

    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }

        public override void TurboBoost()
        {
            //minivans have poor turbo capabilities.
            engState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your engine block exploded!");
        }
    }
}
