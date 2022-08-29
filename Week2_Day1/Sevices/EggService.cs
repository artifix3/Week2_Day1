using Week2_Day1.Models;

namespace Week2_Day1.Sevices
{
    internal class EggService
    {
        public static Egg FryEgg(int howMany)
        {
            Console.WriteLine("Warming the egg pan ... ");
            Task.Delay(3000).Wait();
            Console.WriteLine($"Cracking {howMany} eggs ");
            Console.WriteLine("cooking eggs ... ");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on Plate");
            return new Egg();
        }
        public static async Task<Egg> FryEggAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan ... ");
            await Task.Delay(3000);
            Console.WriteLine($"Cracking {howMany} eggs ");
            Console.WriteLine("cooking eggs ... ");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on Plate");
            return new Egg();

        }
    }
}
