using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string text = Console.ReadLine();
            Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
            Console.ReadLine();
        }
    }
}