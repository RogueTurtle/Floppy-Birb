using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public birbScript birb;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if (birb.alive)
        {
            playerScore += scoreToAdd;
            score.text = playerScore.ToString();
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
