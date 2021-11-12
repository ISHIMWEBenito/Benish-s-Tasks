using System;

namespace Task2
{
    [Serializable()]
    class Engine
    {
        public readonly double fuelTankCapacity, displacement;
        private double amountOfFuel;
        private const double defaultFuelTankCapacity = 40;

        public double AmountOfFuel { get => amountOfFuel; private set => amountOfFuel = value; }

        public Engine(double fuel, double displacement)
        {
            fuelTankCapacity = defaultFuelTankCapacity;
            this.displacement = displacement;
            amountOfFuel = fuel;
        }
        public Engine(double fuel, double displacement, double tankCapacity) : this(fuel, displacement)
        {
            fuelTankCapacity = tankCapacity;
        }
        public double Lp100Km2MPG(double Lp100Km) => 235.214583 / Lp100Km;
        public double MPG2Lp100Km(double MPG) => 235.214583 / MPG;
        public void Work(double km)
        {
            amountOfFuel -= 4 * displacement * km / 100;
            //Console.WriteLine(amountOfFuel);
        }
        public void Refuel(double liters)
        {
            amountOfFuel += liters;
            if (amountOfFuel > fuelTankCapacity)
                amountOfFuel = fuelTankCapacity;
        }
    }
}