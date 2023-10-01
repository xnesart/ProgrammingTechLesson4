using System;

namespace ProgrammingTechLesson4
{
    public class HorseCarriage
    {
        public double TechnicalCondition;
        public double Fuel;
        public double PowerReserve;

        public HorseCarriage(int technicalCondition, double fuel, double powerReserve)
        {
            TechnicalCondition = technicalCondition;
            Fuel = fuel;
            PowerReserve = powerReserve;
        }

        public void Ride(int time)
        {
            if (PowerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (Fuel == 0 || TechnicalCondition == 0 || PowerReserve == 0)
                    {
                        break;
                    }
                    else
                    {
                        TechnicalCondition -= 0.1;
                        Fuel -= 0.95;
                    }
                }
            }
            else
            {
                Console.WriteLine("запас хода меньше, чем расстояние до пункта назначения!");
            }
        }

        public void GetFuel(double value)
        {
            Console.WriteLine($"Кормление лошади на {value}");
            Fuel += value;
            Console.WriteLine($"Лошадь покормлена = {Fuel}");
        }

        public void GetRepair(int value)
        {
            Console.WriteLine("выполняется починка");
            TechnicalCondition += value;
            Console.WriteLine($"состояние повозки = {TechnicalCondition}");
        }
    }
}