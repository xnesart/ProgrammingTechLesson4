using System;

namespace ProgrammingTechLesson4
{
    public class Boat
    {
        public double TechnicalCondition;
        public double Fuel;
        public double PowerReserve;
        public string Order;

        public Boat(int technicalCondition, double fuel, double powerReserve, string order)
        {
            TechnicalCondition = technicalCondition;
            Fuel = fuel;
            PowerReserve = powerReserve;
            Order = order;
        }

        public void Swim(int time)
        {
            if (Order == "права на катер" || PowerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (Fuel == 0 || TechnicalCondition == 0 || PowerReserve == 0)
                    {
                        Console.WriteLine("обслужите катер! остановка!");
                        break;
                    }
                    else
                    {
                        TechnicalCondition -= 0.1;
                        Fuel -= 0.35;
                    }
                }
            }
            else
            {
                if (Order != "права на катер") Console.WriteLine("у вас нет прав на катер!");
                else Console.WriteLine("запас хода меньше, чем расстояние до пункта назначения!");
            }
        }

        public void GetFuel(double value)
        {
                Console.WriteLine($"Заправка на {value}");
                Fuel += value;
                Console.WriteLine($"топливо катера = {Fuel}");
        }

        public void GetRepair(int value)
        {
            Console.WriteLine("выполняется починка");
            TechnicalCondition += value;
            Console.WriteLine($"состояние катера = {TechnicalCondition}");
        }

        public void ChangePilot(string value)
        {
            if (value == "права на катер")
            {
                Order = value;
                Console.WriteLine("пилот допущен к управлению");
            }
            else Console.WriteLine("Пилот не допущен к управлению, проверьте лицензию");
        }
    }
}