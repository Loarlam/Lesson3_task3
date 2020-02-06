using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Plane : Vehicle
    {
        readonly int _planeHight;
        readonly byte _planeNumberOfPassangers;

        public Plane(double vehicleCoordinateX, double vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost, int planeHight, byte planeNumberOfPassangers) :
            base(vehicleCoordinateX, vehicleCoordinateY, vehicleSpeed, vehicleYear, vehicleCost)
        {
            _planeHight = planeHight;
            _planeNumberOfPassangers = planeNumberOfPassangers;
        }

        int PlaneHight => _planeHight;
        byte PlaneNumberOfPassangers => _planeNumberOfPassangers;

        public void GivesOutPlaneCharacteristics()
        {
            Console.WriteLine("Самолётик:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Координаты вылета X: {VehicleCoordinateX}, Y: {VehicleCoordinateY}\nСкорость {VehicleSpeed}\nГод выпуска {VehicleYear}\nСтоимость {VehicleCost}\nМаксимальная высота полета {PlaneHight}\nВместимость {PlaneNumberOfPassangers}\n");
            Console.ResetColor();
        }
    }
}
