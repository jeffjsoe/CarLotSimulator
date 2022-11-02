//JESUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class car
    {
        public car()
        {

        }
        //These are all the properties of a car//Like a blueprint what makes up a car
        public string Make { get; set; } 
        public int Year { get; set; }
        public string Model { get; set; }
        public string EingineNoise { get; set; }

        public string HonkNoise { get; set; }   

        public bool isdrivable { get; set; }
        

        //Here we passed a string called eingine noise into the method
        public void MakeEngineNoise( string EingineNoise)
        {
            Console.WriteLine(EingineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);

        }
    }
}
