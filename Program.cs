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
            for (int i = 0; i < 5; i++) // Allows the user to enter 5 values that will equal sales value
            {
                
                
                Console.WriteLine("Input sales values for each of five stores please!: ");
                string num1;                            // num1 input is a string
                num1 = Console.ReadLine();              // num1 input is stored
                Stored += num1 + "   is ";              //  Added a space after user's input and an "is" before astrisks output

                int num2, asteriskCount;
                num2 = Convert.ToInt32(num1);           // Convert string to integer  
                asteriskCount = num2 / 100;             // Divide integer by 100
                for (int j = 0; j < asteriskCount; j++)
                {
                    Stored += "*";                      // 

                }

                if (i != 4)
                    Stored += "\n ";                    // Adds the store inputs into 5 rows

            }
            Console.WriteLine(Stored);
        }
    }
}