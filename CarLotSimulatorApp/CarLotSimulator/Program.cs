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

            CarLot.numberOfCars++;
            Console.WriteLine($"\nThe number of cars in the Carlot is: {CarLot.numberOfCars}\n ");

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

            CarLot.numberOfCars++;
            Console.WriteLine($"\nThe number of cars in the Carlot is: {CarLot.numberOfCars}\n ");

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

            CarLot.numberOfCars++;
            Console.WriteLine($"\nThe number of cars in the Carlot is: {CarLot.numberOfCars}\n ");

            thirdCar.MakeEngineNoise();

            thirdCar.MakeHonkNoise();

            Console.WriteLine($"--------------------------------------------------------------------------------------\n");

            var myCarLot = new CarLot();

            myCarLot.EsParkingLot.Add(thirdCar);
            myCarLot.EsParkingLot.Add(firstCar);
            myCarLot.EsParkingLot.Add(secondCar);

            foreach (var car in myCarLot.EsParkingLot)
                {
                    Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}...");
                    
                    car.MakeEngineNoise();
                    car.MakeHonkNoise();
                }
            
        }
    }
}
