using RaceTrack.RaceTrack.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class NissanGTR : RaceCar
    {
        public NissanGTR() 
        {
            Name = "Nissan GT-R";
            TopSpeed = 105;

        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} powers up with a thunderous roar. ");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} finishes in position {Position}! What an amazing performance!");
            ;
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine powers down. ");
        }
    }
}
