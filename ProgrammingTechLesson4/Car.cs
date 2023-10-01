using System;

namespace ProgrammingTechLesson4
{
    public class Car
    {
        public double TechnicalCondition;
        public double Fuel;
        public double PowerReserve;
        public string Order;

        public Car(int technicalCondition, double fuel, double powerReserve, string order)
        {
            TechnicalCondition = technicalCondition;
            Fuel = fuel;
            PowerReserve = powerReserve;
            Order = order;
        }

        public void Ride(int time)
        {
            if (Order == "права на автомобиль" || PowerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (Fuel == 0 || TechnicalCondition == 0 || PowerReserve == 0)
                    {
                        Console.WriteLine("обслужите машину! остановка!");
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
                if (Order != "права на автомобиль") Console.WriteLine("у вас нет прав на автомобиль!");
                else Console.WriteLine("запас хода меньше, чем расстояние до пункта назначения!");
            }
        }

        public void GetFuel(double value)
        {
                Console.WriteLine($"Заправка на {value}");
                Fuel += value;
                Console.WriteLine($"топливо автомобиля = {Fuel}");
           
        }

        public void GetRepair(int value)
        {
            Console.WriteLine("выполняется починка");
            TechnicalCondition += value;
            Console.WriteLine($"состояние автомобиля = {TechnicalCondition}");
        }

        public void ChangePilot(string value)
        {
            if (value == "права на автомобиль")
            {
                Order = value;
                Console.WriteLine("водитель допущен к управлению");
            }
            else Console.WriteLine("водитель не допущен к управлению, проверьте лицензию");
        }
    }
}