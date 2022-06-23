using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int maxScore;
    public int upScore;
    public int downScore;
    public int leftScore;
    public int rightScore;

    public BallController ball;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPlayerUpScore(int incerement)
    {
        upScore += incerement;
        if(upScore > maxScore)
        {
            GameOver();
        }
    }
    public void AddPlayerDownScore(int incerement)
    {
        downScore += incerement;
        if (downScore > maxScore)
        {
            GameOver();
        }
    }
    public void AddPlayerLeftScore(int incerement)
    {
        leftScore += incerement;
        if (leftScore > maxScore)
        {
            GameOver();
        }
    }
    public void AddPlayerRightScore(int incerement)
    {
        rightScore += incerement;
        if (rightScore > maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game over");
        gameOverPanel.SetActive(true);
        SceneManager.LoadScene("ReplayOrExit");
    }
}
