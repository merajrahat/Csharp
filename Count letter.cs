using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice9
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
         


            string word = "Ccccccc";
            Console.WriteLine("String: " + word);
            while (word.Length > 0)
            {
                Console.Write(word[0] + " = ");
                int numberOfLetter = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[0] == word[j])
                    {
                        numberOfLetter++;
                    }
                }
                Console.WriteLine(numberOfLetter);
                word = word.Replace(word[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    


        
    }
}
