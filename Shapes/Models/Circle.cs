namespace Shapes.Models{
  public class Circle{
    public int Radius { get; set; }

    public Circle(int radius){
      Radius = radius;
    }
    public double GetCircumference()
    {
      
      return (2 * 3.14) * Radius;
    }
    public double GetDiameter(){
      return Radius * 2;
    }
  }
}