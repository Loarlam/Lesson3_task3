namespace Task3
{
    class Vehicle
    {
        readonly int _vehicleSpeed, _vehicleYear;
        readonly double _vehicleCoordinateX, _vehicleCoordinateY, _vehicleCost;

        //Для быстрого заполнения юзаю сниппет prop + TAB(x2);
        //Затем удаляю метод set;
        //Затем юзаю CTRL+K+E (рефакторинг), который приводит к окончательному виду.
        protected double VehicleCoordinateX => _vehicleCoordinateX;
        protected double VehicleCoordinateY => _vehicleCoordinateY;
        protected int VehicleSpeed => _vehicleSpeed;
        protected int VehicleYear => _vehicleYear;
        protected double VehicleCost => _vehicleCost;

        public Vehicle(double vehicleCoordinateX, double vehicleCoordinateY, int vehicleSpeed, int vehicleYear, double vehicleCost)
        {
            _vehicleCoordinateX = vehicleCoordinateX;
            _vehicleCoordinateY = vehicleCoordinateY;
            _vehicleSpeed = vehicleSpeed;
            _vehicleYear = vehicleYear;
            _vehicleCost = vehicleCost;
        }
    }
}
