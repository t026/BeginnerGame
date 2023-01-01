using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score;
    public Text ScoreText;
    public GameObject GameOverScreen;
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        Score += ScoreToAdd;
        ScoreText.text = "Score: " + Score.ToString();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
