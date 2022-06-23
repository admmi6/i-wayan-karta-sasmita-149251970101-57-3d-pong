using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreManager scoreManager;
    //public Collider ball;
    
    public enum gawangSign { none, gawangUp, gawangDown, gawangLeft, gawangRight };

    public gawangSign currentGawang;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bola")
        {
            Debug.Log("Tes collision instance");
            if (currentGawang == gawangSign.gawangUp)
            {
                Debug.Log("Yes gup" + this);
                scoreManager.AddPlayerUpScore(1);
            } 
            else if(currentGawang == gawangSign.gawangDown)
            {
                //Debug.Log("Yes gdown" + this);
                scoreManager.AddPlayerDownScore(1);
            }
            else if (currentGawang == gawangSign.gawangLeft)
            {
                //Debug.Log("Yes gleft" + this);
                scoreManager.AddPlayerLeftScore(1);
            }
            else if (currentGawang == gawangSign.gawangRight)
            {
                //Debug.Log("Yes gright" + this);
                scoreManager.AddPlayerRightScore(1);
            }
        }
    }
    */
    
    /*
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("instance");
        if (collider == ball)
        {
            Debug.Log("Tes colider instance");
            
            if (currentGawang == gawangSign.gawangUp)
            {
                //Debug.Log("Yes gup" + this);
                scoreManager.AddPlayerUpScore(1);
            }
            else if (currentGawang == gawangSign.gawangDown)
            {
                //Debug.Log("Yes gdown" + this);
                scoreManager.AddPlayerDownScore(1);
            }
            else if (currentGawang == gawangSign.gawangLeft)
            {
                //Debug.Log("Yes gleft" + this);
                scoreManager.AddPlayerLeftScore(1);
            }
            else if (currentGawang == gawangSign.gawangRight)
            {
                //Debug.Log("Yes gright" + this);
                scoreManager.AddPlayerRightScore(1);
            }
        }
    }
    */
}
