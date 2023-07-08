﻿using System;

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
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.Make = "Dodge";
            car1.Model = "Durango";
            car1.year = 2000;
            car1.EngineNoise = "RRRRAAAAAAAAAUUUUUUHHHHHHHHH (BOOM CLATTER CLACK TTSSSS)";
            car1.HonkNoise = "BEEP BEEP";
            car1.IsDriveable = false;

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.year = 2012;
            car2.EngineNoise = "BZZZZZZZZZZZ";
            car2.HonkNoise = "BOOP";
            car2.IsDriveable = true;

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.Make = "Ram";
            car3.Model = "2500";
            car3.year = 1998;
            car3.EngineNoise = "RUMBLERUMBLERUMBLERUMBLERUMBLERUMBLE";
            car3.HonkNoise = "Blep";
            car3.IsDriveable = true;

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            Console.WriteLine($"Cars in the lot: {Car.numberOfCars}");


            //Ehh, another day on these
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
