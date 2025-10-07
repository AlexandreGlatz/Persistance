using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Checkpoint
{
    public VECTOR2 Position { get; set; }
    public Checkpoint(int x, int y)
    {
        Position = new VECTOR2(x, y);
    }
}
