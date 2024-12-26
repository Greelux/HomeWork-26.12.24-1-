using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_26._12._24___1_
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Рік: {Year}");
        }
    }
    public interface IElectricVehicle
    {
        void ChargeBattery();
    }

    public interface IFuelVehicle
    {
        void Refuel();
    }

    public class ElectricCar : Vehicle, IElectricVehicle
    {
        public void ChargeBattery()
        {
            Console.WriteLine("Заряжаю аккумулятор...");
        }
    }


    public class GasolineCar : Vehicle, IFuelVehicle
    {
        public void Refuel()
        {
            Console.WriteLine("Заправляю бензином...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ElectricCar Tesla = new ElectricCar() { Brand = "Tesla", Model = "Model S", Year = 2021 };
            ElectricCar Audi = new ElectricCar() { Brand = "Audi", Model = "Etrone GT", Year = 2022 };
            ElectricCar Haval = new ElectricCar() { Brand = "Haval", Model = "H6Hev", Year = 2024 };
            GasolineCar Bmw = new GasolineCar() { Brand = "BMW", Model = "X5 M", Year = 2024 };
            GasolineCar Porsche = new GasolineCar() { Brand = "Porsche", Model = "911 Turbo S", Year = 2024 };
            GasolineCar Bmw1 = new GasolineCar() { Brand = "BMW", Model = "M8", Year = 2023 };
            
            Bmw.DisplayInfo();
            Bmw.Refuel();

            Porsche.DisplayInfo();
            Porsche.Refuel();

            Bmw1.DisplayInfo();
            Bmw1.Refuel();
            Console.WriteLine();
            Tesla.DisplayInfo();
            Tesla.ChargeBattery();

            Audi.DisplayInfo();
            Audi.ChargeBattery();

            Haval.DisplayInfo();
            Haval.ChargeBattery();

            Console.ReadLine();

        }
    }
}
