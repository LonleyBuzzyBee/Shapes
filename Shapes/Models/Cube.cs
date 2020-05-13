namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set;  }
    public Cube(Rectangle side)
    {
      Face = side;
    }
  }
}