using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n;i++)
            {
                string[] segments = Console.ReadLine().Split("|");
                Car car = new Car(segments[0], int.Parse(segments[1]), int.Parse(segments[2]));
                cars.Add(car);
            }
            string commands;
            while((commands=Console.ReadLine())!="Stop")
            {
                string[] segments = commands.Split(" : ");
                string command = segments[0];
                string carBrand = segments[1];
                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(segments[2]);
                        int fuel = int.Parse(segments[3]);
                        foreach(Car x in cars)
                        {
                            if(carBrand == x.Brand)
                            {
                                if(x.Fuel<fuel)
                                {
                                    Console.WriteLine("Not enough fuel to make that ride");
                                }
                                else
                                {
                                    x.Mileage += distance;
                                    x.Fuel -= fuel;
                                    if(x.Mileage>=100000)
                                    {
                                        cars.Remove(x);
                                        Console.WriteLine($"Time to sell the {x.Brand}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{x.Brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                                    }
                                }
                            }
                        }
                        break;
                    case "Refuel":
                        int fuel1 = int.Parse(segments[2]);
                        foreach(Car x in cars)
                        {
                            if(carBrand == x.Brand)
                            {
                                int oldFuel = x.Fuel;
                                x.Fuel += fuel1;
                                if(x.Fuel>75)
                                {
                                    int more = x.Fuel - 75 + oldFuel;
                                    int refueled = fuel1 - more;
                                    x.Fuel = 75;
                                    Console.WriteLine($"{x.Brand} refueled with {refueled} liters");
                                }
                                else
                                {
                                    Console.WriteLine($"{x.Brand} refueled with {fuel1} liters");
                                }
                            }
                        }
                        break;
                    case "Revert":
                        int kms = int.Parse(segments[2]);
                        foreach(Car x in cars)
                        {
                            if(carBrand==x.Brand)
                            {
                                x.Mileage -= kms;
                                if(x.Mileage<10000)
                                {
                                    x.Mileage = 10000;
                                }
                                else
                                {
                                    Console.WriteLine($"{x.Brand} mileage decreased by {kms} kilometers");
                                }
                            }
                        }
                        break;
                }
            }
            foreach (Car x in cars)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
        public Car(string brand, int mileage, int fuel)
        {
            this.Brand = brand;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public override string ToString()
        {
            return $"{this.Brand} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
        }
    }
}

