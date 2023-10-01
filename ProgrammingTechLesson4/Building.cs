namespace ProgrammingTechLesson4
{
    public class Building
    {
        public int numberOfFloors { get; set; }
        public double square { get; set; }
        public int numberOfTenants { get; set; }
        public bool isResidental { get; set; }

        public Building(int floors, double square, int tenants, bool residental)
        {
            this.numberOfFloors = floors;
            this.square = square;
            this.numberOfTenants = tenants;
            this.isResidental = residental;
        }
    }
}