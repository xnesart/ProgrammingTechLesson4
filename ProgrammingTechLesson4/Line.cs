using System;

namespace ProgrammingTechLesson4
{
    public class Line
    {
        private double startX;
        private double startY;
        private double endX;
        private double endY;

        public Line(double sX, double sY, double eX,double eY)
        {
            startX = sX;
            startY = sY;
            endX = eX;
            endY = eY;
        }
        //проверяет, принадлежит ли точка линии
        public bool isBelongAtLine(Point point)
        {
            double startPos = point.Distance(startX, startY);
            double endPos = point.Distance(endX, endY);
            if (startPos + endPos - this.GetLength() == 0)
            {
                return true;
            }
            return false;
        }
        //вычисляет длину линии
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((endX - startX), 2) +
                             Math.Pow((endY - startY), 2));
        }
    }
}