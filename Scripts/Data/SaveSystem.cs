using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/player.json";

    public static void Save(PlayerData data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    public static PlayerData Load()
    {
        if (!File.Exists(path))
            return new PlayerData();

        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<PlayerData>(json);
    }
}