using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_WK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            astrickCount(); // Calling the method
        }

        static void astrickCount()
        {


            string Stored = " ";


            for (int i = 0; i < 5; i++)
            {
                string input1;
                int input2, asteriskCount;
                Console.WriteLine("Input number of sales please!: ");
                input1 = Console.ReadLine();
                Stored += input1 + "   is ";


                input2 = Convert.ToInt32(input1);
                asteriskCount = input2 / 1;
                for (int j = 0; j < asteriskCount; j++)
                {
                    Stored += "*";

                }

                if (i != 4)
                    Stored += "\n ";

            }
            Console.WriteLine(Stored);
        }
    }
}