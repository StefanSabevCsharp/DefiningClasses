using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
        }
        public void Drive(Car car,double km)
        {
            if(car.FuelAmount - km*FuelConsumptionPerKilometer >= 0)
            {
                FuelAmount -= FuelConsumptionPerKilometer * km;
                TravelledDistance += km;
                
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            
        }
    }
}
