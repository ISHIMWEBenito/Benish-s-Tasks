using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Task2
{
    class Program
    {
        static double ReadDouble(string prompt1, string prompt2, double min=double.MinValue, double max=double.MaxValue)
        {
            double val;
            Console.Write(prompt1);
            while (!double.TryParse(Console.ReadLine(), out val) || val < min || val > max)
                Console.Write(prompt2);
            return val;
        }
        static void Main(string[] args)
        {
            Car car = null;
            FileStream fs;
            if (File.Exists("car.dat"))
            {
                fs = new FileStream("car.dat", FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    car = (Car)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }

            if (car == null)
            {
                Console.Write("Car make: ");
                string make = Console.ReadLine();

                Console.Write("Car model: ");
                string model = Console.ReadLine();

                double displacement = ReadDouble("Engine displacement [l]: ", "Try again: ", 0.01);
                double tankCapacity = ReadDouble("Tank Capacity [l]: ", "Try again: ", 1);
                double fuel = ReadDouble("Amount of fuel [l]: ", "Try again: ", 0, tankCapacity);

                car = new Car(make, model, fuel, displacement, tankCapacity);
            }

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Car simulator");
                Console.WriteLine("[D]rive\n[R]efuel\n[Esc]ape\n");
                car.FuelIndicator();
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D:
                        car.Go(ReadDouble("Enter distance [km]: ", "Try again: ", 0));
                        break;
                    case ConsoleKey.R:
                        car.Refuel(ReadDouble("Enter amount of fuel [l]: ", "Try again: ", 0)); 
                        break;
                    case ConsoleKey.Escape:
                        exit = true;
                        fs = new FileStream("car.dat", FileMode.Create);

                        BinaryFormatter formatter = new BinaryFormatter();
                        try
                        {
                            formatter.Serialize(fs, car);
                        }
                        catch (SerializationException e)
                        {
                            Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                        }
                        finally
                        {
                            fs.Close();
                        }
                        break;
                }
            }
        }
    }
}
