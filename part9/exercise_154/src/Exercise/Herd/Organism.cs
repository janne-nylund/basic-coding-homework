namespace Exercise
{
    public class Organism : IMovable
    {

        private int xCoord;
        private int yCoord;
        public Organism(int x, int y)
        {
            this.xCoord = x;
            this.yCoord = y;
        }
        public void Move(int dx, int dy)
        {
            this.xCoord += dx;
            this.yCoord += dy;
        }

        public override string ToString()
        {
            return "x: " + this.xCoord + "; " + "y: " + this.yCoord;
        }
    }
}