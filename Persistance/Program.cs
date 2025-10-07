// See https://aka.ms/new-console-template for more information
public class Program
{
    static int Main()
    {
        SaveManager saveManager = SaveManager.Instance;
        CheckpointManager checkpointManager = CheckpointManager.Instance;

        Player newPlayer = new Player();
        Checkpoint checkpoint1 = new Checkpoint(0,0);
        Checkpoint checkpoint2 = new Checkpoint(100,100);

        checkpointManager.Checkpoints = new List<Checkpoint>() { checkpoint1, checkpoint2 };
        saveManager.Saveables.Add(newPlayer);

        saveManager.LoadAll("save.json");
        //newPlayer.Load("save.json");

        newPlayer.Hit(2);

        newPlayer.Position = new VECTOR2(10, 10);

        Console.WriteLine(newPlayer.Hp.ToString());
        Console.WriteLine();

        saveManager.SaveAll("save.json");
        //newPlayer.Save("save.json");

        return 0;
    }
}
