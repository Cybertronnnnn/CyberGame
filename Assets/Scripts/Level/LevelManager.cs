using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    private int currentLevel;
    private List<string> levels;

    void Start()
    {
        currentLevel = 0;
        levels = new List<string> { "Level1", "Level2", "Level3" }; // Add your level names here
        LoadLevel(currentLevel);
    }

    void LoadLevel(int levelIndex)
    {
        if (levelIndex < levels.Count)
        {
            Debug.Log("Loading: " + levels[levelIndex]);
            // Your level loading logic goes here
        }
        else
        {
            Debug.Log("No more levels to load!");
        }
    }

    public void NextLevel()
    {
        currentLevel++;
        LoadLevel(currentLevel);
    }
}