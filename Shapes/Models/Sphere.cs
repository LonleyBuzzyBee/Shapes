
namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Face { get; set; }
    public Sphere(Circle radius)
    {
      Face = radius;
    }
    public double GetVolume()
    {

      int length = Face.Radius;

      return (1.3) * (3.14) * (length * length * length);
    }
  }
}