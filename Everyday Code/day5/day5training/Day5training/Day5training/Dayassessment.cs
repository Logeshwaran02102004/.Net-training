using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5training
{


    class vehicle
    {
        private string carNO;
        private string carID;
    public vehicle(string carNO, string carID)
        {
            this.carNO = carNO;
            this.carID = carID;
        }
    protected void displaycardeatails()
        {
            Console.WriteLine("======protected car deatails========");
            Console.WriteLine("the car number is :"+carNO);
            Console.WriteLine("the car id is : " + carID);
        }
    }

    class car:vehicle
    {
        string carname;
        string cartype;
        string fueltype;

        public car(string name,string type,string fueltype,string carNO,string carID):base(carNO,carID)
        {
            this.carname = name;
            this.cartype = type;
            this.fueltype = fueltype;
        }

        public void display()
        {
            displaycardeatails();
            Console.WriteLine("======normal car deatails=====");
            Console.WriteLine("car name :" + carname);
            Console.WriteLine("the cartype : " + cartype);
            Console.WriteLine("the fueltype: "+fueltype);
        }

    }
    internal class Dayassessment
    {
        static void Main(string[] args)
        {
            car car = new car("toyota","hatchpack","petrol","TN22B8766", "wert2345");

            car.display();

        }
    }
}
