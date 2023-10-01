using System;

namespace ProgrammingTechLesson4
{
    public class HorseCarriage
    {
        private double _technicalCondition;
        private double _fuel;
        private double _powerReserve;
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
        public HorseCarriage(int technicalCondition, double fuel, double powerReserve)
        {
            _technicalCondition = technicalCondition;
            _fuel = fuel;
            _powerReserve = powerReserve;
        }

        public void Ride(int time)
        {
            if (_powerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (_fuel == 0 || _technicalCondition == 0 || _powerReserve == 0)
                    {
                        break;
                    }
                    else
                    {
                        _technicalCondition -= 0.1;
                        _fuel -= 0.95;
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
            _fuel += value;
            Console.WriteLine($"Лошадь покормлена = {_fuel}");
        }

        public void GetRepair(int value)
        {
            Console.WriteLine("выполняется починка");
            _technicalCondition += value;
            Console.WriteLine($"состояние повозки = {_technicalCondition}");
        }
    }
}