using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static double tax;
        public static string[] testStr = new string[] { "back ", "to", " basics" };

        static void Main(string[] args)
        {
            /******************************REVERSE STRING***********************/
            String output = "this is the time";
            char[] s = output.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine(s);
            /******************************FIZZBUZZ*******************************/
            fizzBuzz();
            
            /****************************TAX CALCULATOR***************************/
            Console.WriteLine("********** Tax Calculator ***********");
            Console.WriteLine("Enter income amount: ");
            String amount = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (amount != "")
                    {
                        Console.WriteLine("Your taxes due are: {0:C}", incomeTax(amount));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a value.");
                        amount = Console.ReadLine();
                    }
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Enter a number, please.");
                    amount = Console.ReadLine();
                }
            }
            /******************************REVERSE A STRING***************************/
            Console.WriteLine("Enter a string to reverse: ");
            String strReverse = Console.ReadLine();
            Console.WriteLine(reverseChar(strReverse));
            /********Reverse both the string and characters of the string********/
            reverseStr(testStr);
            /******************GET TIMESTAMP IN SECONDS AND PRINT*********************/
            getTime();
        }
        public static double incomeTax(String income)
        {
            double remainder = 0.0;
            double total = Double.Parse(income);
            if (total >= 20000)
            {
                tax = .05 * 20000;
                remainder = total - 20000;
            }

            if (total > 20000 && total <= 50000){
                tax += .10 * remainder;
            }

            if (total > 50000 && total <= 75000)
            {
                tax += .20 * remainder;
            }
            if (total > 75000)
            {
                tax += .75 * remainder;
            }
            return tax;
        }
        public static void getTime()
        {
            DateTime now = DateTime.Now;
            if(now.Second == 0){  
                Console.WriteLine("The new minute is just beginning");
            }
            else if(now.Second == 15){
                Console.WriteLine("We're one quarter done");
            }
            else if(now.Second == 30){
                Console.WriteLine("Half way there");
            }
            else if(now.Second == 45)
            {
                Console.WriteLine("Getting close to done");
            }
            else
            {
                Console.WriteLine("Working on it");
            }
        }
        public static char[] reverseChar(string input)
        {
            char[] charArray = new char[input.Length];
            for(int i = input.Length - 1; i >= 0; i--)
            {
                charArray[(input.Length - 1) - i] = input[i];
            } 
            return charArray;
        }
        public static void reverseStr(string[] input)
        //public static string[] reverseStr(string[] input)
        {
            string[] strArray = new string[input.Length];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                //strArray[(input.Length - 1) - i] = input[i];
                Console.Write(reverseChar(input[i]));
            }
            Console.WriteLine();
            //return strArray;
        }
        public static void fizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }  
        }   
    }
}
