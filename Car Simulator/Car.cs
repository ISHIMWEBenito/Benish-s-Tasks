using System;
using System.Threading;

namespace Task2
{
    [Serializable()]
    class Car
    {
        private string make, model;
        private Engine engine;
        public Car(string make, string model, double fuel, double displacement, double tankCapacity)
        {
            this.make = make;
            this.model = model;
            engine = new Engine(fuel, displacement, tankCapacity);
        }
        public Car(string make, string model, double fuel, double displacement)
        {
            this.make = make;
            this.model = model;
            engine = new Engine(fuel, displacement);
        }
        public Car(string make, string model, Engine engine)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
        }
        public void FuelIndicator()
        {
            Console.WriteLine("Fuel:\n╔═╗");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("║");
                Console.ForegroundColor = ConsoleColor.Green;
                if (j > 7)
                    Console.ForegroundColor = ConsoleColor.Red;
                if (10 * engine.AmountOfFuel / engine.fuelTankCapacity <= 9 - j)
                    Console.Write(" ");
                else
                    Console.Write("█");
                Console.ResetColor();
                Console.WriteLine("║");
            }
            Console.WriteLine("╚═╝");
        }
        public void Go(double km)
        {
            Console.WriteLine("I'm riding!");
            string left = "";
            string seq = @"/-\|";
            int width = Console.WindowWidth - 15;
            int kmPerChar = (int)Math.Round(km / width);
            if (kmPerChar < 1)
                kmPerChar = 1;

            for (int i = 0; i < (int)km; i++)
            {
                if (i % kmPerChar == 0 || i == (int)km-1)
                {
                    left = new string(' ', (int)Math.Round(i * width / km));
                    Console.Clear();
                    Console.WriteLine(left + @"    ____" + "\n" +
                                      left + @" __/  |_\_" + "\n" +
                                      left + @"|  _     _``-." + "\n" +
                                      left + @"'-(_)---(_)--'");

                    FuelIndicator();
                }
                engine.Work(1);
                for(int j=0; j<10; j++)
                    if(10 * engine.AmountOfFuel / engine.fuelTankCapacity <= 9 - j)
                    {
                        Console.SetCursorPosition(1, 6+j);
                        Console.Write(" ");
                    }
                if (engine.AmountOfFuel <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("        OUT OF FUEL!");
                    Console.ResetColor();
                }
                
                if (i == (int)km - 1 || engine.AmountOfFuel <= 0)
                    break;
                Console.SetCursorPosition(3 + left.Length, 3);
                Console.Write(seq[i % 4]);
                Console.SetCursorPosition(9 + left.Length, 3);
                Console.Write(seq[i % 4]);
                
                Thread.Sleep(100);
            }
            //engine.Work(km);
            //Console.WriteLine("Here I am!");
            Console.WriteLine("[Press Enter]");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        public void Refuel(double liters) => engine.Refuel(liters);
    }
}