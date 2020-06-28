using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YeelightAPI;

namespace YeelightController
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World to AB Room!");

            Device coolLight = new Device("192.168.86.22");

            await coolLight.Connect();

            Random coolGenerator = new Random(new Random().Next(2, 10));

            int redValue = coolGenerator.Next(10, 200);
            int greenValue = coolGenerator.Next(50, 250);
            int blueValue = coolGenerator.Next(100, 300);

            Console.WriteLine($"RedValue : {redValue}");
            Console.WriteLine($"RedValue : {greenValue}");
            Console.WriteLine($"RedValue : {blueValue}");

            await coolLight.SetRGBColor(redValue, greenValue, blueValue);

            await coolLight.SetBrightness(coolGenerator.Next(50, 100), coolGenerator.Next(100, 3000));

        }

        private static void WriteLineWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
