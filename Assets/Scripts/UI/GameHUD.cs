using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour {
    public Text scoreText;
    public Text levelText;
    public Text healthText;
    private int score = 0;
    private int level = 1;
    private int health = 100;

    void Start() {
        UpdateHUD();
    }

    public void AddScore(int points) {
        score += points;
        UpdateHUD();
    }

    public void SetLevel(int newLevel) {
        level = newLevel;
        UpdateHUD();
    }

    public void SetHealth(int newHealth) {
        health = newHealth;
        UpdateHUD();
    }

    void UpdateHUD() {
        scoreText.text = "Score: " + score;
        levelText.text = "Level: " + level;
        healthText.text = "Health: " + health;
    }
}