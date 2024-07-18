using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter a sentence: ");
            string inputSentence = Console.ReadLine();
            foreach (string line in inputSentence.Split(args, StringSplitOptions.RemoveEmptyEntries))
            {
                count++;
            }
            //foreach(char line in inputSentence)
            //{
            //    if (line == ' ')
            //    {
            //        ++count;
            //    }
            //}
            //Console.WriteLine($"Number of words in the above sentence is : {count+1}");
            Console.WriteLine($"Number of words in the above sentence is : {count}");
        }
    }
}
