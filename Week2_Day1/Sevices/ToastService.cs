﻿using Week2_Day1.Models;

namespace Week2_Day1.Sevices
{
    internal class ToastService
    {
        public static void ApplyJam(Toast toast)=> Console.WriteLine("Putting jam on toast");
        public static void ApplyButter(Toast toast) => Console.WriteLine("Putting butter on toast");
        public static Toast ToastBread(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("Putting a slice of breat in the toaster");
            }
            Console.WriteLine("Start Testing");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove Toast from Toaster");
            return new Toast();
        }

        public static async Task ApplyJamAsync(Toast toast) => Console.WriteLine("Putting jam on toast");
        public static async Task ApplyButterAsync(Toast toast) => Console.WriteLine("Putting butter on toast");
        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("Putting a slice of breat in the toaster");
            }
            Console.WriteLine("Start Testing");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove Toast from Toaster");
            return new Toast();
        }
    }
}
