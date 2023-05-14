using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int p = 0; p < 10; p++)
            {
                Console.WriteLine(p);
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");


            }


            int j = 10;
            while (j > 0)
            {

                Console.WriteLine(j + " ");
                j--;

            }

            int i = 30;

            while (i >= 0)
            {
                i--;

                if (i % 2 == 0)
                {

                    Console.WriteLine(i + " ");

                }


            }

            


            
            }
    }
}
