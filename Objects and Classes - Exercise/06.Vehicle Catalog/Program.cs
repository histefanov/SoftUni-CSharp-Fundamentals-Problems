using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Vehicle_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCatalog catalog = new VehicleCatalog();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleData = input.Split();
                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsepower = int.Parse(vehicleData[3]);

                if (type == "car")
                {
                    catalog.Cars.Add(new Car(model, color, horsepower));
                }
                else
                {
                    catalog.Trucks.Add(new Truck(model, color, horsepower));
                }
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = input;
                bool isCar = catalog.Cars.Exists(car => car.Model == model);

                if (isCar)
                {
                    int index = catalog.Cars.FindIndex(car => car.Model == model);
                    catalog.Cars[index].PrintInfo();
                }
                else
                {
                    int index = catalog.Trucks.FindIndex(truck => truck.Model == model);
                    catalog.Trucks[index].PrintInfo();
                }
            }

            Console.WriteLine(
                $"Cars have average horsepower of: {catalog.GetAverageHorsepower("car"):F2}." + "\n" +
                $"Trucks have average horsepower of: {catalog.GetAverageHorsepower("truck"):F2}.");
        }

        class VehicleCatalog
        {
            public VehicleCatalog()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();
            }

            public List<Car> Cars;
            public List<Truck> Trucks;

            public double GetAverageHorsepower(string type)
            {
                double averageHorsepower;

                if (type == "car")
                {
                    averageHorsepower = 
                        this.Cars.Aggregate(0, (total, next) => total + next.Horsepower) * 1.0 / this.Cars.Count;
                }
                else
                {
                    averageHorsepower =
                        this.Trucks.Aggregate(0, (total, next) => total + next.Horsepower) * 1.0 / this.Trucks.Count;
                }

                if (double.IsNaN(averageHorsepower))
                {
                    return 0.0;
                }

                return averageHorsepower;
            }

        }

        class Car
        {
            public Car(string model, string color, int horsepower)
            {
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public string Model;
            public string Color;
            public int Horsepower;

            public void PrintInfo()
            {
                Console.WriteLine(
                    $"Type: Car\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}");
            }
        }
        class Truck
        {
            public Truck(string model, string color, int horsepower)
            {
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public string Model;
            public string Color;
            public int Horsepower;

            public void PrintInfo()
            {
                Console.WriteLine(
                    $"Type: Truck\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.Horsepower}");
            }
        }
    }
}
