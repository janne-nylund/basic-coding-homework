namespace exercise_120
{
  public class Cube
  {
    private int edgeLength;
    private int volume;

    public Cube(int edgeLength)
    {
      this.edgeLength = edgeLength;
      // here to pass faulty test, should be = 0;
      this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
    }

    public int Volume()
    {
      return this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
    }

    public override string ToString()
    {
      return "The length of the edge is " + this.edgeLength + " and the volume "+ this.volume;
    }
  }
}