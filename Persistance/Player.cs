using System;
using System.Text.Json;

public class Player : ISaveable
{
	public int Hp {get;set;}
	public VECTOR2 Position {get;set;}

	CheckpointManager _checkpointManager;

	public Player()
	{
		Hp = 20;
		_checkpointManager = CheckpointManager.Instance;
	}

	public void Hit(int damage)
	{
		Hp -= damage;
	}

	public void Save(string filepath)
	{
		Checkpoint closest = _checkpointManager.GetClosestCheckpoint(Position);
		Position = closest.Position;

		string json = JsonSerializer.Serialize(this);
		File.WriteAllText(filepath, json);
	}

	public void Load(string filepath)
	{
		if(File.Exists(filepath) == false)
			return;

		string jsonString = File.ReadAllText(filepath);
		Player player = JsonSerializer.Deserialize<Player>(jsonString)!;

		Hp = player.Hp;
    }
}
