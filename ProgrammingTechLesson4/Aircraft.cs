using System;

namespace ProgrammingTechLesson4
{
    public class Aircraft
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

        public Aircraft(int technicalCondition, double fuel, double powerReserve, string order)
        {
            _technicalCondition = technicalCondition;
            _fuel = fuel;
            _powerReserve = powerReserve;
            _order = order;
        }

        public void Fly(int time)
        {
            if (_order == "лицензия пилота" || _powerReserve > time)
            {
                for (int i = 0; i < time; i++)
                {
                    if (_fuel == 0 || _technicalCondition == 0 || _powerReserve == 0)
                    {
                        Console.WriteLine("обслужите самолёт! Полет прекращен");
                        break;
                    }
                    else
                    {
                        _technicalCondition -= 0.1;
                        _fuel -= 0.5;
                    }
                }
            }
            else
            {
                if (_order != "лицензия пилота") Console.WriteLine("у вас нет прав на полеты!");
                else Console.WriteLine("запас хода меньше, чем время полёта, мы не полетим!");
            }
        }

        public void GetFuel(double value)
        {
                Console.WriteLine($"Заправка на {value}");
                _fuel += value;
        }

        public void GetRepair(double value)
        {
            Console.WriteLine("выполняется починка");
            _technicalCondition += value;
            Console.WriteLine($"состояние самолета = {_technicalCondition}");
        }

        public void ChangePilot(string value)
        {
            if (value == "лицензия пилота")
            {
                _order = value;
                Console.WriteLine("пилот допущен к управлению");
            }
            else Console.WriteLine("Пилот не допущен к управлению, проверьте лицензию");
        }
    }
}