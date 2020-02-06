using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        int _vehicleCoordinateX, _vehicleCoordinateY, _vehicleSpeed, _vehicleYear;
        double _vehicleCost;

        //Для быстрого заполнения юзаю сниппет propfull + TAB(x2)
        public int MyProperty
        {
            get { return _vehicleCoordinateX; }
        }

        public int VehicleCoordinateY
        {
            get { return _vehicleCoordinateY; }
        }

        public int VehicleSpeed 
        {
            get { return _vehicleSpeed; }
        }

        public int VehicleYear
        {
            get { return _vehicleYear; }
        }

        public double VehicleCost
        {
            get { return _vehicleCost; }
        }

        public Vehicle(int vehicleCoordinateX, int vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost)
        {
            _vehicleCoordinateX = vehicleCoordinateX;
            _vehicleCoordinateY = vehicleCoordinateY;
            _vehicleSpeed = vehicleSpeed;
            _vehicleYear = vehicleYear;
            _vehicleCost = vehicleCost;
        }
    }
}
