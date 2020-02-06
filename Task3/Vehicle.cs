using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Vehicle
    {
        //int _vehicleCoordinateX, _vehicleCoordinateY, _vehicleSpeed, _vehicleYear;
        //double _vehicleCost;

        //Для быстрого заполнения юзаю сниппет propfull + TAB(x2)
        private int _vehicleCoordinateX;

        public int MyProperty
        {
            get { return _vehicleCoordinateX; }
            set { _vehicleCoordinateX = value; }
        }

        private int _vehicleCoordinateY;

        public int VehicleCoordinateY
        {
            get { return _vehicleCoordinateY; }
            set { _vehicleCoordinateY = value; }
        }

        private int _vehicleSpeed;

        public int VehicleSpeed 
        {
            get { return _vehicleSpeed; }
            set { _vehicleSpeed = value; }
        }

        private int _vehicleYear;

        public int VehicleYear
        {
            get { return _vehicleYear; }
            set { _vehicleYear = value; }
        }

        private double _vehicleCost;

        public double VehicleCost
        {
            get { return _vehicleCost; }
            set { _vehicleCost = value; }
        }

        public Vehicle(int vehicleCoordinateX, int vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost)
        {
            _vehicleCoordinateX = vehicleCoordinateX;
            _vehicleCoordinateY = vehicleCoordinateY;
            _vehicleSpeed = vehicleSpeed;
            _vehicleYear = vehicleYear;
        }
    }
}
