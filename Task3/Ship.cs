using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Ship : Vehicle
    {
        readonly int _shipNumberOfPassengers;
        readonly string _shipHomePort;

        public Ship(double vehicleCoordinateX, double vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost, int shipNumberOfPassengers, string shipHomePort) :
            base(vehicleCoordinateX, vehicleCoordinateY, vehicleSpeed, vehicleYear, vehicleCost)
        {
            _shipNumberOfPassengers = shipNumberOfPassengers;
            _shipHomePort = shipHomePort;
        }

        int ShipNumberOfPassengers => _shipNumberOfPassengers;
        string ShipHomePort => _shipHomePort;

        public void GivesOutShipCharacteristics()
        {
            Console.WriteLine("Кораблик:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Координаты выплыва X: {VehicleCoordinateX}, Y: {VehicleCoordinateY}\nСкорость {VehicleSpeed}\nГод выпуска {VehicleYear}\nСтоимость {VehicleCost}\nВместимость {ShipNumberOfPassengers}\nПорт приписки {ShipHomePort}\n");
            Console.ResetColor();
        }
    }
}
