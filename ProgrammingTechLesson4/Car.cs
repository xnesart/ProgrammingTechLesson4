using System;

namespace ProgrammingTechLesson4
{
    public class Car
    {
        private double _technicalCondition;
        private double _fuel;
        private double _powerReserve;
        private string _order;

        public double TechnicalCondition
        {
            get { return _technicalCondition; }
            private set { }
        }
        public double Fuel
        {
            get { return _fuel; }
            private set { }
        }
        public double PowerReserve
        {
            get { return _powerReserve; }
            private set { }
        }
        public Car(int technicalCondition, double fuel, double powerReserve, string order)
        {
            _technicalCondition = technicalCondition;
            _fuel = fuel;
            _powerReserve = powerReserve;
            _order = order;
        }

        public void Ride(int time)
        {
            if (_order == "права на автомобиль" || _powerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (_fuel == 0 || _technicalCondition == 0 || _powerReserve == 0)
                    {
                        Console.WriteLine("обслужите машину! остановка!");
                        break;
                    }
                    else
                    {
                        _technicalCondition -= 0.1;
                        _fuel -= 0.35;
                    }
                }
            }
            else
            {
                if (_order != "права на автомобиль") Console.WriteLine("у вас нет прав на автомобиль!");
                else Console.WriteLine("запас хода меньше, чем расстояние до пункта назначения!");
            }
        }

        public void GetFuel(double value)
        {
            Console.WriteLine($"Заправка на {value}");
            _fuel += value;
            Console.WriteLine($"топливо автомобиля = {_fuel}");
        }

        public void GetRepair(int value)
        {
            Console.WriteLine("выполняется починка");
            _technicalCondition += value;
            Console.WriteLine($"состояние автомобиля = {_technicalCondition}");
        }

        public void ChangePilot(string value)
        {
            if (value == "права на автомобиль")
            {
                _order = value;
                Console.WriteLine("водитель допущен к управлению");
            }
            else Console.WriteLine("водитель не допущен к управлению, проверьте лицензию");
        }
    }
}