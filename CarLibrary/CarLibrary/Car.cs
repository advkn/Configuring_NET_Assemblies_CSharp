using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarLibrary
{
    //Represents the state of the engine.
    public enum EngineState
    {
        engineAlive,
        engineDead
    }

    //which type of music player does this car have?
    public enum MusicMedia
    {
        musicCd,
        musicTape,
        musicRadio,
        musicMp3
    }

    //The abstract base class in ther hierarchy
    public abstract class Car
    {

        public string PetName
        {
            get;
            set;
        }

        public int CurrentSpeed
        {
            get;
            set;
        }

        public int MaxSpeed
        {
            get;
            set;
        }

        public void TurnOnRadio(bool musicOn, MusicMedia mm)
        {
            if (musicOn)
            {
                MessageBox.Show(string.Format("Jamming {0}", mm));
            }
            else
            {
                MessageBox.Show("Quiet time...");
            }
        }

        protected EngineState engState = EngineState.engineAlive;

        public EngineState EngineState
        {
            get { return engState; }
        }

        public abstract void TurboBoost();


        public Car() {
            MessageBox.Show("CarLibrary Version 2.0!");
        }

        public Car(string name, int maxSp, int currSp)
        {
            MessageBox.Show("CarLibrary Version 2.0!");
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }
    }
}
