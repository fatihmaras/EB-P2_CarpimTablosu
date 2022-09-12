using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CarpimTablosuOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int J = 1; J <= 10; J++)
                {
                    Console.WriteLine(i + "x" + J + "=" + (i * J));
                }

            }
            Console.ReadLine();
        }
    }
}
