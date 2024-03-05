using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoP_Ex48
{
    class Program
    {
        public static void Table()                                 //prints multplication table up to 10 for int given
        {
            int num;

            Console.Write("\nEnter Number to Multiple: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplaction Table: {num}");
            Console.WriteLine("------------------------");
            for (int j = 1; j <= 10; j++)
            {
                int m = num * j;
                Console.WriteLine($"{num,5} * {j,-4}|{m,6}");

            }
            Console.WriteLine();
        }


         public static int Sq(int i)                                    //prints the square of given int
        {                                                               
            int s = i * i;
            Console.WriteLine($"{i}^2 = {s}");
            return s;
        }

        public static void Cube()                              //uses sq() to print the cube of given int
        {
            int num;

            Console.Write("\nEnter Number to Square and Cube: ");
            num = int.Parse(Console.ReadLine());

            int c = Sq(num) * num;
            Console.WriteLine($"{num}^3 = {c}\n");
        }


        public static void Sum()                        //takes any number of ints in an array and prints sum
        {
            int sum = 0;
            string[] firstMultipleInput = new string[] { };
            int[] numArr;// = new int[firstMultipleInput.Length];
            int count;// = numArr.Length;

            Console.Write("\nEnter Numbers to Find Sum: ");
            firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            numArr = new int[firstMultipleInput.Length];
            count = numArr.Length;

            for (int i = 0; i < firstMultipleInput.Length; i++)
            {
                numArr[i] = int.Parse(firstMultipleInput[i]);
            }

            for (int i = 0; i < count; i++)
            {
                sum += numArr[i];
            }
            Console.WriteLine($"{sum}\n");
        }


        public static string Menu()                                     //prints menu and takes arg to run desired funtions
        {
            
            string runF;
            

            Console.WriteLine("What function would you like to run: \n " +
                "1. Multiplication Table {MT} \n" +
                " 2. Square/Cube {SC} \n" +
                " 3. Sum {S}\n");

            runF = Console.ReadLine();

            if (runF == "end")
            {
                Console.Write("\nThank you for participating. \nGoodbye!\n");
            }
            else if (runF == "1" || runF == "Multiplication Table" || runF == "multiplication table" || runF == "MT" || runF == "mt")
            {
                Table();
            }
            else if (runF == "2" || runF == "Square/Cube" || runF == "square/cube" || runF == "SC" || runF == "sc")
            {
                Cube();
            }
            else if (runF == "3" || runF == "Sum" || runF == "sum" || runF == "S" || runF == "s")
            {
                Sum();
            }
            else
            {
                Console.WriteLine("\nInvalid Entry. Try Again.\n");
            }

            return runF;
        }


        static void Main(string[] args)
        {
            string end;

            do
            {
                 end = Menu();

            } while (end != "end");

        }
    }
}
