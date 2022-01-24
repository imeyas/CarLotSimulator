using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {

        public static int numberOfCars;
        public CarLot()
        {
            CarLot.numberOfCars++;
            Console.WriteLine($"\nThe number of cars in the Carlot is: {CarLot.numberOfCars}\n ");
        }

        public List<Car> EsParkingLot { get; set; } = new List<Car>();
    }
}
