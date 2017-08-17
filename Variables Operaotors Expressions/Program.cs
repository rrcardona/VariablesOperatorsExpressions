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
            //string name = "Ricardo";
            //Console.WriteLine(name);

            //name = "Dave";
            //Console.WriteLine(name);
            //string Name = "Ricardo";

            //string birthMonth = "February";
            //Console.WriteLine(birthMonth);
            //int birthMonthNumber = 2;
            ////integers
            //int age = 65;
            //int population = 100000;
            //Floating Type Variables
            //float number = 2.1644003304897294383961032f;
            //double someNumber = 2.1644003304897294383961032d;
            //decimal partialNumber = 2.1644003304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //Boolean 
            //bool isPresent = true;
            //bool seatTaken = false;
            //Character
            //char lastLetter = 'j';

            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge < samAge);

            //At a restaurant, Mike and his three friends decided to divide the bill evenly. If each person paid 13 dollars, then what was the total bill

            int mike = 13;
            int friendA = 13;
            int friendB = 13;
            int friendC = 13;
            Console.WriteLine(mike + friendA + friendB + friendC);


            //Lisa is cooking mufins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How many more cups does she need to put in?

            int sugar = 7;
            int sugarUsed = 2;

            Console.WriteLine(sugar - sugarUsed);

            //How many packages of diapers can you with $40 if one package costs $8?

            int diapers = 8;
            int money = 40;

            Console.WriteLine(money / diapers);

            //Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41. How much money did he recieve?

            int trevor = 29;
            int total = 41;

            Console.WriteLine(total - trevor);

            //Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?

            int julia = 47;
            int pranav = 30;

            Console.WriteLine(julia - pranav);

            //How many boxes of envelopes can you buy with $12 if one box costs $3

            int envelopes = 3;
            int wallet = 12;

            Console.WriteLine(wallet / envelopes);

            //After paying $5.12 for a salad, Norachai has $27.10. How much money did he have before buying the salad?

            float salad = 5.12f;
            float balance = 27.10f;

            Console.WriteLine(salad + balance);

            //331 students went on a field trip. Six buses were filled and 7 students traveled in cars. How many students were in each bus?

            int students = 331;
            int carRiders = 7;
            int totalBus = 6;
            int studentsInBuses = students - carRiders;
            int averageBusLoad = studentsInBuses / totalBus;
            Console.WriteLine(averageBusLoad);

            //Aliyah had $24 to spend on seven pencils.After buying them she had $10.How much did each pencil cost ?

            float totalMoney = 24f;
            int pencils = 7;
            float remainder = 10f;
            float moneySpent = totalMoney - remainder;
            float pencilCost = moneySpent / pencils;
            Console.WriteLine(pencilCost);

            //The sum of three consecutive numbers is 72.What are the smallest of these numbers?

            int finalNumber = 72;
            int averageNumber = finalNumber / 3;
            int smallestConsecutiveNumber = averageNumber - 1;
            int largestConsecutiveNumber = averageNumber + 1;
            Console.WriteLine(smallestConsecutiveNumber);

            //The sum of three consecutive even numbers is 48.What are the smallest of these numbers?
            //fff
            int finalNumbers = 48;
            int consectiveNumbers = finalNumbers / 3;
            int smallNumber = consectiveNumbers - 2;
            int largeNumber = consectiveNumbers = 2;
            Console.WriteLine(smallNumber);

            //Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. There are now only 22 boxes left. With how many did she start?

            int totalBoxesLeft = 22;
            int bought = 7;
            int begin = (totalBoxesLeft * 2) - bought;
            Console.WriteLine(begin);




























        }
    }
}
