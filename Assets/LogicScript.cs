using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public manScript player;

    public void updateScore(int newScore)
    {   
        if (player.isAlive) {
            score += newScore;
            scoreText.text = score.ToString();
        }
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        player.isAlive = false;
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
