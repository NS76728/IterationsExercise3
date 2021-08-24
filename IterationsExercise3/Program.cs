using System;

namespace IterationsExercise3
{
    class Program
    {
        public static void absoluteValue()
        {
            for (int i =1000; i>=-1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void jumping3()
        {
            for (int i = 3; i <=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static void intequals(int firstnum, int secondnum)
        {
            if (firstnum==secondnum)
            {
                Console.WriteLine("they eqaul");
            }
            else
            {
                Console.WriteLine("they dont equal");
            }
        }

        public static void evenodd(int ed_num)
        {
            if(ed_num % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the neumber is odd");
            }

        }

        public static void pos_neg(int pn_num)
        {
            if (pn_num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("the number is positive");
            }

           
        }

        public static void voterEligability(int age)
        {
            if (age >=18)
            {
                Console.WriteLine("You can vote! Enjoy democracy!");
            }
            else
            {
                Console.WriteLine("You can vote yet, sorry");
            }
        }

        public static void withinRange(int range)
        {
            if (range > -10 && range<10 )
            {
                Console.WriteLine("the number inputed is between -10 and 10");
            }
            else
            {
                Console.WriteLine("the number is not in the specific range");
            }
        }

        public static void multiTable(int multi)
        {
            for (int i=1; i <= 12; i++)
            {
                int table = multi * i;
                Console.WriteLine(table);
            }
        }





        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            absoluteValue();
            jumping3();

            Console.WriteLine("Enter a number");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            intequals(firstnum, secondnum);
            
            Console.WriteLine("Enter a number to find out if its even or odd");
            int ed_num = Convert.ToInt32(Console.ReadLine());
            evenodd(ed_num);
            
            Console.WriteLine("Enter a number to find out if its positive or negative");
            int pn_num = Convert.ToInt32(Console.ReadLine());
            pos_neg(pn_num);
            

            Console.WriteLine("Enter the age of the potential voter");
            var age = Int32.Parse(Console.ReadLine());
            voterEligability(age);
            

            Console.WriteLine("Enter a number");
            int range = Convert.ToInt32(Console.ReadLine());
            withinRange(range);
            

            Console.WriteLine("Enter a number");
            int multi = Convert.ToInt32(Console.ReadLine());
            multiTable(multi);




        }
    }
}
