using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public birbScript birb;
    public Text highscore;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if (birb.alive)
        {
            playerScore += scoreToAdd;
            score.text = playerScore.ToString();
        }
        
    }

    private void OnEnable()
    {
        highscore.text = "High Score: " + PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        int finScore = int.Parse(score.text);
        HighScore(finScore);
        highscore.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }

    public void HighScore(int intScore)
    {
        if (PlayerPrefs.GetInt("highscore", 0) < intScore)
        {
            PlayerPrefs.SetInt("highscore", intScore);
        }
    }
}
