using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{

    /*Who is Jaghatai Khan? - source - https://wh40k.lexicanum.com/wiki/White_Scars
    The White Scars were the V Legion of the original twenty Space Marine Legions of the First Founding. 
    Their Primarch is Jaghatai Khan. During the Horus Heresy the White Scars remained loyal to the Emperor, after which they reorganized and split into Chapters. 
    Drawing on the tribal savagery of their homeworld, the White Scars practice a highly mobile method of warfare, tearing into their enemies with lightning-quick attacks and vanishing before a response can be made.
    They rely on speeders, and other extremely mobile machines. 
    The White Scars Primarch is the perfect driver for the GT-R and our Racecar assignment :D

    */
    public class JaghataiKhan : Driver
    {
        public JaghataiKhan(RaceCar car) : base(car) 
        {
            Name = "Jaghatai Khan";
            SkillLevel = 9;


        }
        
        
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
