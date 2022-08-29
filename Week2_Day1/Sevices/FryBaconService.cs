using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_Day1.Models;

namespace Week2_Day1.Sevices
{
    internal class FryBaconService
    {
        public static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Putting {slices} slices of bacon in the pan");
            Console.WriteLine($"Cooking first side of bacon");
            Task.Delay(3000).Wait();
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("Cooking the second of bacon ...");
            Task.Delay(3000).Wait();
            return new Bacon();

        }
        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Putting {slices} slices of bacon in the pan");
            Console.WriteLine($"Cooking first side of bacon");
            await Task.Delay(3000);
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("Cooking the second of bacon ...");
            await Task.Delay(3000);
            return new Bacon();


        }
    }
}
