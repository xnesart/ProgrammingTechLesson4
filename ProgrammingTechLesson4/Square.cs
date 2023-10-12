namespace ProgrammingTechLesson4
{
    public class Square
    {
        private Point pointStart;
        private Point pointEnd;
        private Line line;

        public Square(Point leftTopAngle, double side)
        {
            double startPointX = leftTopAngle.GetX();
            double startPointY = leftTopAngle.GetY();
            Point endPoint = ReturnPointForSquare(startPointX, startPointY, side);
            line = new Line(leftTopAngle, endPoint);
        }

        private Point ReturnPointForSquare(double pointX, double pointY, double side)
        {
            double sidePointX = CalculateCoord(pointX, side);
            Point tempPoint = new Point(sidePointX, pointY);
            return tempPoint;
        }

        private double CalculateCoord(double startPointX, double side)
        {
            return startPointX - side;
        }

        public double getSquare()
        {
            return line.GetLength() * line.GetLength();
        }

        public double getPerimeter()
        {
            return 4 * line.GetLength();
        }
        public bool ContainsPoint(Point point, Point leftAngle)
        {
            double x = point.GetX();
            double y = point.GetY();

            double squareX = leftAngle.GetX();
            double squareY = leftAngle.GetY();

            // Проверяем, находится ли точка внутри квадрата
            return x >= squareX && x <= squareX + line.GetLength() &&
                   y >= squareY && y <= squareY + line.GetLength();
        }
    }
}