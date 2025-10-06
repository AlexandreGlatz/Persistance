// See https://aka.ms/new-console-template for more information
public class Program
{
    static int Main()
    {
        Player newPlayer = new Player();

        newPlayer.Load("save.json");

        newPlayer.Hit(2);

        Console.WriteLine(newPlayer.Hp.ToString());

        newPlayer.Save("save.json");

        return 0;
    }
}
