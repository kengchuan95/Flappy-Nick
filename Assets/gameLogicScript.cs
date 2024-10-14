using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    public GameObject mainScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (BirdScript.birdIsAlive) { 
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
