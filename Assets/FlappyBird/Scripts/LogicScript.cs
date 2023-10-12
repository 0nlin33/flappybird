using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public FlappyBirdPlayer player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore+ scoreToAdd;
        scoreText.text= playerScore.ToString(); 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
            highScoreText.text = "High Score: "+highScore.ToString();
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("FlappyBird");
        gameStartScreen.SetActive(false);
    }
    public void GameExit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("FlappyBird_Menu");
    }
}
