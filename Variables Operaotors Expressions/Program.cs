using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Operators_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ricardo";
            //Console.WriteLine(name);

            name = "Dave";
            //Console.WriteLine(name);
            string Name = "Ricardo";

            string birthMonth = "February";
            //Console.WriteLine(birthMonth);
            int birthMonthNumber = 2;
            //integers
            int age = 65;
            int population = 100000;
            //Floating Type Variables
            float number = 2.1644003304897294383961032f;
            double someNumber = 2.1644003304897294383961032d;
            decimal partialNumber = 2.1644003304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //Boolean 
            bool isPresent = true;
            bool seatTaken = false;
            //Character
            char lastLetter = 'j';

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);


        }
    }
}
