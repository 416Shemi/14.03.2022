using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Model
{
    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacitiy ;
        public int FuelFor1Km;
        public double CurrentFuel;
        public double ShowInfo;
        public int Drive;
        
        public Car(string brand,string model,double fulecapacitiy,int fuelfor1km, double currentFuel, int drive, int year,double showInfo)
        {
            this.Brand = brand;
            this.Model = model;
            this.FuelCapacitiy = fulecapacitiy;
            this.FuelFor1Km=fuelfor1km;
            this.CurrentFuel = currentFuel;
            this.Drive = drive;
            this.Year = year;
            this.ShowInfo = showInfo;

            if (CurrentFuel / Drive >= FuelFor1Km)
            {
                double ShowInfo = CurrentFuel - (FuelFor1Km * Drive);
                Console.WriteLine(ShowInfo);
            }
            else
            {
                Console.WriteLine("kifayet qeder benzin yoxdur");

            }
            
       
            
        }
    }
}
