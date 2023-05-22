using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç elemanlı : ");
            int arrayİndex = Convert.ToInt32(Console.ReadLine());

            int[] Arrays = new int[arrayİndex];

            for (int i = 0; i < Arrays.Length; i++)
            {
                Console.WriteLine((i +1) + ". elemanı gir");
                Arrays[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------");

            foreach (int i in Arrays)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();


            


        }
    }
}
