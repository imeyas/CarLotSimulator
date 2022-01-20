using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Console.WriteLine($"\nMY FIRST CAR'S SWAG BE LIKE:");
            var firstCar = new Car()
            {
                Year = 2017,
                Make = "Chevy",
                Model = "Malibu",
                EngineNoise = "Vroom",
                HonkNoise = "Peep peep",
                IsDriveable = true,
            };

            firstCar.MakeEngineNoise();

            firstCar.MakeHonkNoise();

            Console.WriteLine($"\nMY SECOND CAR'S SWAG BE LIKE:");

            var secondCar = new Car()
            {
                Year = 1977,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "Vrooooooommmmmmm",
                HonkNoise = "Peeeeeeep",
                IsDriveable = true,
            };

            secondCar.MakeEngineNoise();

            secondCar.MakeHonkNoise();

            Console.WriteLine($"\nAND MY THIRD CAR PULLS UP LIKE:");

            var thirdCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "S3XY",
                EngineNoise = "Pmmmmmmm",
                HonkNoise = "Peep",
                IsDriveable = true,
            };

            thirdCar.MakeEngineNoise();

            thirdCar.MakeHonkNoise();




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
