using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;
    public GameObject settingsPanel;

    void Start() {
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(ShowSettings);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    void ShowSettings() {
        settingsPanel.SetActive(true);
    }

    void QuitGame() {
        Application.Quit();
    }
}