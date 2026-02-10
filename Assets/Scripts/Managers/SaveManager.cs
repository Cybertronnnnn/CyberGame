using System.IO;
using UnityEngine;

public static class SaveManager
{
    private static string savePath = Path.Combine(Application.persistentDataPath, "gameData.json");

    public static void SaveGame(GameData data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, json);
        Debug.Log("Game saved to " + savePath);
    }

    public static GameData LoadGame()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            GameData data = JsonUtility.FromJson<GameData>(json);
            Debug.Log("Game loaded from " + savePath);
            return data;
        }
        Debug.LogWarning("Save file not found!");
        return null;
    }
}

[System.Serializable]
public class GameData
{
    public int playerScore;
    public Vector3 playerPosition;
// Add other game data fields you need
}