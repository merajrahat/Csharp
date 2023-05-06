using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice8IfElse
{
    internal class Program
    {
      

            /* int num1, num2, num3;

             Console.WriteLine("Write the value for num1");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Write the value for num2");
             num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Write the value for num3");
             num3 = Convert.ToInt32(Console.ReadLine());


             if (num1 > num2)
             {
                 Console.WriteLine("Num1 is greater than num2");

                 if (num1 > num3)
                 {
                     Console.WriteLine("Num1 has the largest value");

                 }
                 else
                 {
                     Console.WriteLine("Num3 is not the largest");
                 }
             }*/

            int i, num;

            //Reading number
            Console.WriteLine("Enter number to print table: ");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 10; i >= 1; i--)
            {
                //Printing table of number entered by user              
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }

            Console.WriteLine("Enter number to print table: ");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                //Printing table of number entered by user            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }




            string name = "United States of America";

            for (int j = name.Length - 1; j >= 0; j--)
            {
                Console.Write(name.ToCharArray()[j] + " ");

            }

            string name1 = "aciremA fo setatS detinU";

            for (int k = 0; k <= name1.Length - 1; k++)
            {

                Console.Write(" " + name.ToCharArray()[k] + " ");
            }


            string name2;
            String wel = "Welcome ";
            string day = "Have a nice day";

            Console.WriteLine("Enter your name: ");
            name2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(wel + name2);
            Console.WriteLine(day);

            

        }
    }
}
