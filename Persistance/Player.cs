using System;
using System.Text.Json;

public class Player : ISaveable
{
	public int Hp {get;set;}

	public Player()
	{
		Hp = 20;
	}

	public void Hit(int damage)
	{
		Hp -= damage;
	}

	public void Save(string filepath)
	{
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
