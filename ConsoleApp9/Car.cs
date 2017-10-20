using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Car
    {
        private string vin;
        private string make;

        public string Vin
        {
            set { vin = value; }
            get { return vin; }
        }

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public Car()
        {
            Vin = " ";
            Make = " ";

        }

        public Car(string Cvin, string Cmake )
        {
            Vin = Cvin;
           Make = Cmake;
        }

        public override string ToString()
        {
            return (Vin + " " + Make);
        }

    }
}
