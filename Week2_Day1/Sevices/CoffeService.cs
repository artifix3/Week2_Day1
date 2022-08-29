using Week2_Day1.Models;

namespace Week2_Day1.Sevices
{
    internal class CoffeService
    {
        public static Coffe PourCoffe()
        {
            Console.WriteLine("Pouring Coffe");
            return new Coffe(); 
        }
        public static async Task<Coffe> PourCoffeAsync()
        {
            Console.WriteLine("Pouring coffe");
            return new Coffe();
        }
    }
}
