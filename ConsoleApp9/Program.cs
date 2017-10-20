using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("43224", "Ford");
            Car Car2 = new Car("73728", "Tesla");

            NascarCar Car3 = new NascarCar("39842", "Cruz","Awesome");
            NascarCar Car4 = new NascarCar("49928", "Fiesta", "Everyone");

            NascarCar Car5 = new NascarCar("93828", "Mini", "Drag");
            NascarCar Car6 = new NascarCar("49928", "Cooper", "Star");

            Car[] CarList = new Car[6];

            CarList[0] = Car1;
            CarList[1] = Car2;
            CarList[2] = Car3;

            CarList[3] = Car4;
            CarList[4] = Car5;
            CarList[5] = Car6;

            for (int i = 0; i < CarList.Length; i++)
            {
                // Compiler always calls a ToString method when you try and print an object
                Console.WriteLine(CarList[i]);
            }


        }
    }
}
