using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Car : Vehicle
    {
        readonly string _carTransmission, _carType;

        public Car(double vehicleCoordinateX, double vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost, string carTransmission, string carType) :
            base(vehicleCoordinateX, vehicleCoordinateY, vehicleSpeed, vehicleYear, vehicleCost)
        {
            _carTransmission = carTransmission;
            _carType = carType;
        }

        string CarTransmission => _carTransmission;
        string CarType => _carType;

        public void GivesOutCarCharacteristics()
        {
            Console.WriteLine("Машинка:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Координаты выезда X: {VehicleCoordinateX}, Y: {VehicleCoordinateY}\nСкорость {VehicleSpeed}\nГод выпуска {VehicleYear}\nСтоимость {VehicleCost}\nТрансмиссия {CarTransmission}\nТип {CarType}\n");
            Console.ResetColor();
        }

    }
}
