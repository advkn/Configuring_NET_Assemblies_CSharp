using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarLibrary;

namespace CarLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# CarLibrary Client App *****");
            //make a sports car
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();
            viper.TurnOnRadio(true, MusicMedia.musicCd);

            //make a minivan
            MiniVan mv = new MiniVan();
            mv.TurboBoost();
            Console.ReadLine();
        }
    }
}
