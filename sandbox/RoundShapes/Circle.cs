using System.Net.NetworkInformation;

class Circle : RoundShape
{
    protected double _radius;

    public void SetRadius(double r) {_radius = r;}

    public override double Area() {return Math.PI * _radius * _radius;}
}