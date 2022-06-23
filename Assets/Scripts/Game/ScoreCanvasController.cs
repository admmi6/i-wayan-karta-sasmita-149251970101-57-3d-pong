using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvasController : MonoBehaviour
{
    public Text scorePlayerUp;
    public Text scorePlayerDown;
    public Text scorePlayerLeft;
    public Text scorePlayerRight;

    public Text winnerPlayer;

    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorePlayerUp.text = scoreManager.upScore.ToString();
        scorePlayerDown.text = scoreManager.downScore.ToString();
        scorePlayerLeft.text = scoreManager.leftScore.ToString();
        scorePlayerRight.text = scoreManager.rightScore.ToString();
    }
}
