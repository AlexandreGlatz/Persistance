class SaveManager
{
    public static SaveManager Instance = new SaveManager();
    public List<ISaveable> Saveables;
    public SaveManager()
    {
        Saveables = new List<ISaveable>();
    }

    public void SaveAll(string filepath)
    {
        foreach (ISaveable saveable in Saveables)
            saveable.Save(filepath);
    }

    public void LoadAll(string filepath)
    {
        foreach (ISaveable saveable in Saveables)
            saveable.Load(filepath);
    }
}

