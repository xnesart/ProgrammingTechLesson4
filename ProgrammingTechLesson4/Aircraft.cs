using System;

namespace ProgrammingTechLesson4
{
    public class Aircraft
    {
        public double TechnicalCondition;
        public double Fuel;
        public double PowerReserve;
        public string Order;

        public Aircraft(int technicalCondition, double fuel, double powerReserve, string order)
        {
            TechnicalCondition = technicalCondition;
            Fuel = fuel;
            PowerReserve = powerReserve;
            Order = order;
        }

        public void Fly(int time)
        {
            if (Order == "лицензия пилота" || PowerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (Fuel == 0 || TechnicalCondition == 0 || PowerReserve == 0)
                    {
                        Console.WriteLine("обслужите самолёт! Полет прекращен");
                        break;
                    }
                    else
                    {
                        TechnicalCondition -= 0.1;
                        Fuel -= 0.5;
                    }
                }
            }
            else
            {
                if (Order != "лицензия пилота") Console.WriteLine("у вас нет прав на полеты!");
                else Console.WriteLine("запас хода меньше, чем время полёта, мы не полетим!");
            }
        }

        public void GetFuel(double value)
        {
                Console.WriteLine($"Заправка на {value}");
                Fuel += value;
        }

        public void GetRepair(double value)
        {
            Console.WriteLine("выполняется починка");
            TechnicalCondition += value;
            Console.WriteLine($"состояние самолета = {TechnicalCondition}");
        }

        public void ChangePilot(string value)
        {
            if (value == "лицензия пилота")
            {
                Order = value;
                Console.WriteLine("пилот допущен к управлению");
            }
            else Console.WriteLine("Пилот не допущен к управлению, проверьте лицензию");
        }
    }
}