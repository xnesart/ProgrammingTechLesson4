using System;

namespace ProgrammingTechLesson4
{
    public class Line
    {
        private Point startPoint;
        private Point endPoint;

        public Line(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
        //проверяет, принадлежит ли точка линии
        public bool isBelongAtLine(Point point)
        {
            double startPos = point.Distance(startPoint.GetX(), startPoint.GetY());
            double endPos = point.Distance(endPoint.GetX(), endPoint.GetY());
            if (startPos + endPos - this.GetLength() == 0)
            {
                return true;
            }
            return false;
        }
        //вычисляет длину линии
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((endPoint.GetX() - startPoint.GetX()), 2) +
                             Math.Pow((endPoint.GetY() - startPoint.GetY()), 2));
        }
    }
}