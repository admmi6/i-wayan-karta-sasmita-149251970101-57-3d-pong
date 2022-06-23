using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int maxScore;
    public int upScore;
    public int downScore;
    public int leftScore;
    public int rightScore;

    public GameObject pUp;
    public GameObject pDowm;
    public GameObject pLeft;
    public GameObject pRight;

    public GameObject TembokUp;
    public GameObject TembokDowm;
    public GameObject TembokLeft;
    public GameObject TembokRight;

    public SpawnManager spawnManager;
    public GameObject gameOverPanel;
    public GameObject hideBackBtn;

    public GameObject winerPlayer;
    public Text finalWinner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CekWinner();
        if(spawnManager.loseCount.Count >= 3)
        {
            finalWinner.text = winerPlayer.gameObject.name;
            gameOverPanel.SetActive(true);
            hideBackBtn.SetActive(false);
        }
    }

    public void AddPlayerUpScore(int incerement)
    {
        upScore += incerement;
        if(upScore >= maxScore)
        {
            pUp.GetComponent<PlayerController>().isOver = true;
            spawnManager.loseCount.Add(pUp);
            pUp.SetActive(false);
            TembokUp.SetActive(true);
        }
    }
    public void AddPlayerDownScore(int incerement)
    {
        downScore += incerement;
        if (downScore >= maxScore)
        {
            pDowm.GetComponent<PlayerController>().isOver = true;
            spawnManager.loseCount.Add(pDowm);
            pDowm.SetActive(false);
            TembokDowm.SetActive(true);
        }
    }
    public void AddPlayerLeftScore(int incerement)
    {
        leftScore += incerement;
        if (leftScore >= maxScore)
        {
            pLeft.GetComponent<PlayerController>().isOver = true;
            spawnManager.loseCount.Add(pLeft);
            pLeft.SetActive(false);
            TembokLeft.SetActive(true);
        }
    }
    public void AddPlayerRightScore(int incerement)
    {
        rightScore += incerement;
        if (rightScore >= maxScore)
        {
            pRight.GetComponent<PlayerController>().isOver = true;
            spawnManager.loseCount.Add(pRight);
            pRight.SetActive(false);
            TembokRight.SetActive(true);
        }
    }

   
    public void CekWinner()
    {
        if(pUp.GetComponent<PlayerController>().isOver == false)
        {
            winerPlayer = pUp;
        } 
        else if (pDowm.GetComponent<PlayerController>().isOver == false)
        {
            winerPlayer = pDowm;
        } 
        else if (pLeft.GetComponent<PlayerController>().isOver == false)
        {
            winerPlayer = pLeft;
        } 
        else if (pRight.GetComponent<PlayerController>().isOver == false)
        {
            winerPlayer = pRight;
        }
    }

    
}
