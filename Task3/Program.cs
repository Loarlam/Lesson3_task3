/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Vehicle.  
В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
Создайте 3 производных класса Plane, Саг и Ship.  
Для класса Plane должна быть определена высота и количество пассажиров.  
Для класса Ship — количество пассажиров и порт приписки.  
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
*/
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(62.975227, 59.905699, 900, 1993, 1200000, 10000, 44);
            plane.GivesOutPlaneCharacteristics();
            Ship ship = new Ship(49.772513, 61.907563, 50, 1982, 280000000, 200, "Матушка Россия");
            ship.GivesOutShipCharacteristics();
            Car car = new Car(22.546912, 73.518796, 180, 2017, 800000, "Автоматическая", "Минивэн");
            car.GivesOutCarCharacteristics();

            Console.ReadKey();
        }
    }
}
