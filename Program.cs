using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while loop fo reference");
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("The for loop");
            for(int j=0;j<=5;j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
