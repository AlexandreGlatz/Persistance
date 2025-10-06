using System;

public interface ISaveable
{
	public void Save(string savepath);
	public void Load(string filepath);
}
