using System.Runtime.InteropServices;

class Cylinder : Circle
{
    private double _height;

    public void SetHeight(double h) {_height = h;}
    public override double Area() 
    {
        return 2 * Math.PI * _radius * (_radius + _height);
    }
}