using System;
using _16._10Practice.Interfaces;

namespace _16._10Practice.Models
{
	public class Car:IVehicle
	{

        public double MileAge { get; private set; }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public Car(double fuel = 20, double tankcapacity = 40, double fuelconsumption = 10)
        {
            Fuel = fuel;
            TankCapacity = tankcapacity;
            FuelConsumption = fuelconsumption;
        }



        public bool Drive(double kilometer)
        { 
            double fuelneeded = kilometer * FuelConsumption / 100;

            if (fuelneeded<= Fuel)
            {
                Fuel -= fuelneeded;
                MileAge += kilometer;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Refuel(double amount)
        {

            if (amount<0)
            {
                Colored.WriteLine("Səhv daxil etmisən");
                return false;
            }
            if (Fuel+amount>TankCapacity)
            {
                Fuel = TankCapacity;
            }
            else
            {
                Fuel += amount;
            }
            return true;

        }


    }
}

