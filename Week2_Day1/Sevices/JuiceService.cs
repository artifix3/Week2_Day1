using Week2_Day1.Models;

namespace Week2_Day1.Sevices
{
    internal class JuiceService
    {
        public static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange Juice");
            return new Juice(); 
        }
        public static async Task<Juice> PourOJAsync()
        {
            Console.WriteLine("Pouring Orange Juice");
            return new Juice();
        }
    }
}
