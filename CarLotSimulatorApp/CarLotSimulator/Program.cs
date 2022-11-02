//JESUS
using System;
using System.Runtime.InteropServices;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            car mycar1=new car();
            //This automatically jsut increments the number of car each time it is created
            //numberofCars=
            CarLot.numberOfCars++;
            mycar1.Make = "Lambo";
            mycar1.Year = 2020;
            mycar1.isdrivable = true;
            mycar1.Model = "Diablo";
            mycar1.EingineNoise = "vroom";
            mycar1.HonkNoise = "hONKKKKK";
            mycar1.MakeEngineNoise(mycar1.EingineNoise);
            //-Be speciif when you call a method in a class because since there are multiple of the same properties in the class. 
            mycar1.MakeHonkNoise(mycar1.HonkNoise);
            car mycar2 = new car();
            CarLot.numberOfCars++;
            mycar2.Make = "Ferrari";
            mycar2.Year = 1990;
            mycar2.isdrivable = false;
            mycar2.Model = "Enzo";
            mycar2.EingineNoise = "Vrumm";
            mycar2.HonkNoise = "Hooooonk";
            mycar2.MakeHonkNoise(mycar2.HonkNoise);
            mycar2.MakeEngineNoise(mycar2.EingineNoise);


            car mycar3 = new car();
            CarLot.numberOfCars++;
            mycar3.Make = "Toyota";
            mycar3.Year = 2018;
            mycar3.isdrivable = true;
            mycar3.Model = "Camry";
            mycar3.EingineNoise = "Silent";
            mycar3.HonkNoise = "Yeeehaww";
            mycar3.MakeEngineNoise(mycar3.EingineNoise);
            mycar3.MakeHonkNoise(mycar3.HonkNoise);

            Console.WriteLine(CarLot.numberOfCars);
            

            //So here we are using objext initilizer syntax
            var mycar4 = new car() { Year = 2013, Make = "Ford, " };



            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           
        }
    }
}
