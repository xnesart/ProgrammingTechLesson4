using System;

namespace ProgrammingTechLesson4
{
    public class Point
    {
        private double coordinatesX;
        private double coordinatesY;

        private double DistanceFromStart;

        public Point(double coordinatesX, double coordinatesY)
        {
            this.coordinatesX = coordinatesX;
            this.coordinatesY = coordinatesY;
            DistanceFromStart = 0;
        }

        public void SetPointCoordinates(double x, double y)
        {
            coordinatesX = x;
            coordinatesY = y;
        }

        /// <summary>
        /// вычисляет расстояние от точки до начала координат
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(coordinatesX - 0, 2) + Math.Pow(coordinatesY - 0, 2));
        }
        public double Distance(double desiredX, double dexiredY)
        {
            return Math.Sqrt(Math.Pow(coordinatesX - desiredX, 2) +
                             Math.Pow(coordinatesY - dexiredY, 2));
        }
    }
}