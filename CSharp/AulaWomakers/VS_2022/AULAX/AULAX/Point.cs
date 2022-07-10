using System;



struct Point
{
    public int x;
    public int y;



    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"Point: x={x} y={y}";
    }
}