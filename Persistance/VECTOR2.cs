using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct VECTOR2
{
    public int X;
    public int Y;

    public VECTOR2(int x, int y) {  X = x; Y = y; }
    public static int Magnitude(VECTOR2 left, VECTOR2 right) { return left.X * left.X + left.Y * right.Y; }

    public void Print() { Console.WriteLine("X : " + } 
}
