using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _08.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog vehicleCatalog = new Catalog();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = input.Split('/');
                string currentVehicleType = vehicleInfo[0];

                if (currentVehicleType == "Car")
                {
                    vehicleCatalog.Cars.Add(
                        new Car(vehicleInfo[1], vehicleInfo[2], vehicleInfo[3]));
                }
                else
                {
                    vehicleCatalog.Trucks.Add(
                        new Truck(vehicleInfo[1], vehicleInfo[2], vehicleInfo[3]));
                }
            }

            if (vehicleCatalog.Cars.Count > 0)
            {
                vehicleCatalog.printCarInfo();
            }

            if (vehicleCatalog.Trucks.Count > 0)
            {
                vehicleCatalog.printTruckInfo();
            }          
        }

        class Car
        {
            public Car(string brand, string model, string horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsePower;
            }

            public string Brand;
            public string Model;
            public string HorsePower;
        }

        class Truck
        {
            public Truck(string brand, string model, string weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }

            public string Brand;
            public string Model;
            public string Weight;
        }

        class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars;
            public List<Truck> Trucks;

            public void printCarInfo()
            {
                Console.WriteLine("Cars:");
                this.Cars
                    .OrderBy(car => car.Brand)
                    .ToList()
                    .ForEach(car =>
                        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp"));
            }

            public void printTruckInfo()
            {
                Console.WriteLine("Trucks:");
                this.Trucks
                    .OrderBy(truck => truck.Brand)
                    .ToList()
                    .ForEach(truck =>
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg"));
            }
        }
    }
}
