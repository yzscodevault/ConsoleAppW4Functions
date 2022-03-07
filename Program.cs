using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char conti = 'y';
                while (conti == 'Y' || conti == 'y')
                {
                    SelectTask();//call switch function
                    Console.WriteLine("Please enter y or Y to continue");
                    conti = Char.Parse(Console.ReadLine());
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            Console.ReadLine();
        }
        static void SelectTask()
        {
            try
            {
                Console.WriteLine("Please enter a digit to select a function:");
                string[] functionMenu = new string[] { "Let's see all even natural numbers that are less than 100.", "Which year is a leap year?", "Do you want to see what you entered in a reverse way?", "How many spaces exactly in a given string?" };
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i+1}. {functionMenu[i]}");
                }
                Console.WriteLine("Please enter your selection: ");
                int j = Convert.ToInt32(Console.ReadLine());
                switch (j){
                    case 1:
                        EvenNumberReturn();
                        break;
                    case 2:
                        IsThatALeapYear();
                        break;
                    case 3:
                        ReverseIt();
                        break;
                    case 4:
                        SpaceCounter();
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message + "only enter a digit to make the selection, please");
            }
        }
        static void EvenNumberReturn()
        {
            string[] evenNumberArray= new string[100] ;
            for (int i = 2; i < 100; i+=1)
            {
                if (i % 2 == 0)
                {
                    evenNumberArray[i-2]=Convert.ToString(i);
                }
                else { evenNumberArray[i-2] = " "; }
            }
            Console.WriteLine("All even natural numbers that are less than 100: ");
            foreach (string j in evenNumberArray)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        static void IsThatALeapYear()
        {
            try
            {
                Console.WriteLine("Please enter a year to see if it's a leap year:");
                int year = Int32.Parse(Console.ReadLine());
                string yearResult =
                (year % 4 == 0) || (year % 400 == 0) ? "is" : "is NOT";
                Console.WriteLine("The year {0} {1} a leap year", year, yearResult);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message + "only enter Four digits as year, please");
            }
        }
        
        static void ReverseIt()
        {
            Console.WriteLine("Please enter a string you want to see it reversed:");
            string originString = Console.ReadLine();
            int i = originString.Length-1;
            List<string> reversingArrary= new List<string>();
            foreach (char c in originString)
            {
                reversingArrary.Add(Convert.ToString(c));
            }
            foreach (string s in reversingArrary)
            {
                while (i >= 0)
                {
                    Console.Write(reversingArrary[i]);
                    i--;
                }
            }
            Console.WriteLine();
        }
        static void SpaceCounter()
        {
            Console.WriteLine("Please enter a string to see how many spaces in it:");
            string s = Console.ReadLine();
            int i = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    i += 1;
                }
            }
            Console.WriteLine("\"{0}\" contains {1} spaces", s,i);
        }
    }
}
