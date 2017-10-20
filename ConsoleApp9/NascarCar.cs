using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class NascarCar:Car
    {
        private string teamname;
       

        public string Teamname
        {
            set { teamname = value; }
            get { return teamname; }
        }

       
        public NascarCar()
        {
            Vin = " ";
            Make = " ";
            Teamname = " ";
        

        }


        public NascarCar(string Cvin, string Cmake, string Nteamname)
        {
            Vin = Cvin;
            Make = Cmake;
            Teamname = Nteamname;
        }

        public override string ToString()
        {
            return (Make + " " + Vin + " " +Teamname);
        }


    }
}
