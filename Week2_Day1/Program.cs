//sync
using Week2_Day1.Models;
using Week2_Day1.Sevices;

//Console.WriteLine("Process is sync ");
//Coffe coffe= CoffeService.PourCoffe();
//Console.WriteLine("Coffe is ready ");

//Egg Egg = EggService.FryEgg(2);
//Console.WriteLine("Eggs are ready");

//Bacon bacon = FryBaconService.FryBacon(3);
//Console.WriteLine("Bacons are ready");

//Toast toast = ToastService.ToastBread(2);
//Console.WriteLine("Toast is ready");

//Juice juice = JuiceService.PourOJ();
//Console.WriteLine("OJ is ready");
//Console.WriteLine("Breakfast is Ready");


//Console.WriteLine("Process is Async");
//Console.ForegroundColor=ConsoleColor.Red;
////Console.WriteLine("".PadRight(50,'-'));
//Console.WriteLine(new String('_',50)+"\n");
//Console.ResetColor();

////Coffe coffe1 = CoffeService.PourCoffeAsync().Result;
////Console.WriteLine("Coffe is ready");

////Egg egg1 = EggService.FryEggAsync(2).Result;
////Console.WriteLine("Eggs are ready");

////Toast toast1 = ToastService.ToastBreadAsync(2).Result;
////Console.WriteLine("Toast is ready");

////Juice juice1 = JuiceService.PourOJAsync().Result;
////Console.WriteLine("OJ is ready");
////Console.WriteLine("Breakfast is Ready");
Task<Egg> eggTask = EggService.FryEggAsync(2);
Task<Bacon> baconTask = FryBaconService.FryBaconAsync(2);
Task<Toast> toastTask = ToastService.ToastBreadAsync(2);

//Coffe
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Coffe is ready");
Console.ResetColor();
Console.WriteLine(new String('-', 80)+"\n");
//Toast
Console.ForegroundColor = ConsoleColor.Green;
Toast toast1 = await toastTask;
ToastService.ApplyButter(toast1);

ToastService.ApplyJam(toast1);

Console.WriteLine("Toast is ready");
Console.ResetColor();
Console.WriteLine(new String('-', 80) + "\n");


//Juice
Console.ForegroundColor = ConsoleColor.Blue;
Juice oj = JuiceService.PourOJ();
Console.WriteLine("Juice is ready");
Console.ResetColor();
Console.WriteLine(new String('-', 80) + "\n");

//Egg
Console.ForegroundColor = ConsoleColor.Blue;
Egg eggsasync = await eggTask;
Console.WriteLine("Eggs are ready");
Console.ResetColor();
Console.WriteLine(new String('-', 80) + "\n");

//Bacon
Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(new String('-', 80) + "\n");


