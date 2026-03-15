class Sphere : Circle
{
    public override double Area()
    {
        //return 4 * Math.PI * _radius * _radius;
        return 4 * base.Area();
    }
}