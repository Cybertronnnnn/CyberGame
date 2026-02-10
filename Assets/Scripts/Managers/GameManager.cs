using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    
    public enum GameState { MainMenu, Playing, Paused, GameOver }
    public GameState currentState;

    private int currentLevel = 1;
    private int totalLevels = 5;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    
    private void Start() {
        TransitionToState(GameState.MainMenu);
    }

    public void TransitionToState(GameState newState) {
        currentState = newState;
        switch (currentState) {
            case GameState.MainMenu:
                // Load main menu
                break;
            case GameState.Playing:
                // Start game logic
                break;
            case GameState.Paused:
                // Pause game logic
                break;
            case GameState.GameOver:
                // Handle game over logic
                break;
        }
    }
    
    public void AdvanceLevel() {
        if (currentLevel < totalLevels) {
            currentLevel++;
            // Load new level logic
        } else {
            // Handle game completion
        }
    }
}