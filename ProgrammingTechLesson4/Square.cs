namespace ProgrammingTechLesson4
{
    public class Square
    {
        private double startPointX;
        private double startPointY;
        private double lineStartX;
        private double lineStartY;
        private double lineEndX;
        private double lineEndY;

        private Line line;
        public Square(double leftTopAngleX, double leftTopAngleY, int side)
        {
            startPointX = leftTopAngleX;
            startPointY = leftTopAngleY;
            line = new Line(startPointX,startPointY, startPointX - side, startPointY);
        }
        
        public double getSquare()
        {
            return line.GetLength() * line.GetLength();
        }
        public double getPerimeter()
        {
            return 4 * line.GetLength();
        }

    }
}