using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class CheckpointManager
{
    public static CheckpointManager Instance = new CheckpointManager();
    public List<Checkpoint> Checkpoints;

    public CheckpointManager()
    {
        Checkpoints = new List<Checkpoint>();
    }

    public Checkpoint GetClosestCheckpoint(VECTOR2 position)
    {
        int shortest = VECTOR2.Magnitude(Checkpoints[0].Position, position); 
        Checkpoint shortestCheckpoint = Checkpoints[0];
        for(int i = 1; i<Checkpoints.Count; ++i)
        {
            int test = VECTOR2.Magnitude(Checkpoints[i].Position, position);
            if ( test < shortest)
            {
                shortest = test;
                shortestCheckpoint = Checkpoints[i];
            }
        }

        return shortestCheckpoint;
    }
}

