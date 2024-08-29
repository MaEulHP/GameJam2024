using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class GameOverPopup : MonoBehaviour
{
    public GameObject GameOverUI;
    public Text ScoreText;
    public Button RestartButton;
    public Button QuitButton;

    private void Start()
    {
        RestartButton.onClick.AddListener(Restart);
        QuitButton.onClick.AddListener(Quit);
    }

    void Update()
    {
        if (GameManager.instance.isGameover)
        {
            ShowGameOverUI();
        }

        ScoreText.text = "Score : " + GameManager.instance.score.ToString("F3");
    }

    void ShowGameOverUI()
    {
        GameOverUI.SetActive(true);
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
