using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PreTestPostTestLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //======================================
            //          Define Variables 
            //======================================
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

            //======================================
            //   Post Test with Do/While Loop
            //======================================
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            //======================================
            //        For Loop (Pre Test)
            //======================================
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
     
            for (int x = 0; x <= 10; x = x + 2)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
