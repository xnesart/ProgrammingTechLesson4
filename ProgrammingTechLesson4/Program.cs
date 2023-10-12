using System;

namespace ProgrammingTechLesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Точка
            Console.WriteLine("задание 1");
            Point somePoint = new Point(4, 6);
            double pointResult = somePoint.Distance();
            Console.WriteLine("Расстояние точки от начала координат = " + pointResult);
            //Линия
            Point startPoint = new Point(6, 6);
            Point endPoint = new Point(3, 6);
            Line line = new Line(startPoint,endPoint);
            Console.WriteLine($"Длина линии = {line.GetLength()}");
            Console.WriteLine($"Точка принадлежит линии = {line.isBelongAtLine(somePoint)}");
            //Квадрат
            Point leftAngle = new Point(3, 3);
            Square square = new Square(leftAngle, 3);
            Point searchPoint = new Point(3, 3);
            Console.WriteLine($"Искомая точка принадлежит квадрату = {square.ContainsPoint(searchPoint,leftAngle)}");
            Console.WriteLine($"Площадь квадрата = {square.getSquare()}"); 
            Console.WriteLine($"Периметр квадрата = {square.getPerimeter()}");
            
            //Разработать класс, инкапсулирующий информацию о зданиях, в том числе о домах, складских помещениях, учреждениях.
            //В этом классе (Building) будут храниться три элемента информации о зданиях:
            //количество этажей, общая площадь и количество жильцов.
            //Описание нового типа данных Building разместить в отдельном файле Building.cs, который должен быть включен в проект.
            //Основной код программы должен использовать описанный в Building.cs класс:
            // •	создать 2 экземпляра (House, Office) нового класса
            // •	инициализовать значения полей обоих экземпляров
            // •	продемонстрировать состояние созданных объектов путем вывода содержимого их полей
            // •	создать признак, помогающий отличать объекты класса определенного вида (например, отличительный признак офисного и жилого здания)
            // 
            
            //создаем офис
            Console.WriteLine("задание 2");
            Building office = new Building(3,100,0,false);
            Console.WriteLine($"количество этажей в здании = {office.numberOfFloors}");
            Console.WriteLine($"площадь в здании = {office.square}");
            Console.WriteLine($"количество жильцов = {office.numberOfTenants}");
            Console.WriteLine($"Здание жилое? = {office.isResidental}");


            Building house = new Building(1, 30, 2, true);
            Console.WriteLine($"количество этажей в здании = {house.numberOfFloors}");
            Console.WriteLine($"площадь в здании = {house.square}");
            Console.WriteLine($"количество жильцов = {house.numberOfTenants}");
            Console.WriteLine($"здание жилое? = {house.isResidental}");
            
            
            //Задание 3
            //Вы участвуете в разработке компьютерной игры.
            //В качестве объектов игрового мира выступают средства транспорта различных типов
            //реализовать эти классы, затем протестировать их с помощью описанных процедур перемещения, изменения состояния.
            Console.WriteLine("задание 3");
            Aircraft smallAircraft = new Aircraft(100, 100, 100, "лицензия пилота");
            smallAircraft.Fly(30);
            Boat smallBoat = new Boat(100, 100, 100, "права на катер");
            smallBoat.Swim(40);
            Car niceCar = new Car(100, 100,100 ,"права на автомобиль");
            niceCar.Ride(60);
            HorseCarriage carriage = new HorseCarriage(100, 100, 100);
            carriage.Ride(80);
            
            Console.WriteLine($"|Самолёт| Топливо: {Math.Round(smallAircraft.Fuel,4)} | Состояние: {Math.Round(smallAircraft.TechnicalCondition,4)}");
            Console.WriteLine($"|Катер| Топливо: {Math.Round(smallBoat.Fuel,4)} | Состояние: {Math.Round(smallBoat.TechnicalCondition,4)}");
            Console.WriteLine($"|Машина| Топливо: {Math.Round(niceCar.Fuel,4)} | Состояние: {Math.Round(niceCar.TechnicalCondition,4)}");
            Console.WriteLine($"|Повозка| Топливо: {Math.Round(carriage.Fuel,4)} | Состояние: {Math.Round(carriage.TechnicalCondition,4)}");
            smallAircraft.GetFuel(10);
            smallAircraft.GetRepair(1);
            smallBoat.GetFuel(10);
            smallBoat.GetRepair(2);
            niceCar.GetFuel(10);
            niceCar.GetRepair(4);
            carriage.GetFuel(50);
            carriage.GetRepair(5);
            Console.WriteLine($"|Самолёт| Топливо: {Math.Round(smallAircraft.Fuel,4)} | Состояние: {Math.Round(smallAircraft.TechnicalCondition,4)}");
            Console.WriteLine($"|Катер| Топливо: {Math.Round(smallBoat.Fuel,4)} | Состояние: {Math.Round(smallBoat.TechnicalCondition,4)}");
            Console.WriteLine($"|Машина| Топливо: {Math.Round(niceCar.Fuel,4)} | Состояние: {Math.Round(niceCar.TechnicalCondition,4)}");
            Console.WriteLine($"|Повозка| Топливо: {Math.Round(carriage.Fuel,4)} | Состояние: {Math.Round(carriage.TechnicalCondition,4)}");
        }
    }
}