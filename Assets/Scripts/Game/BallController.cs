using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;

    public ScoreManager scoreManager;
    public SpawnManager spawnManager;
    public Collider gawangUp;
    public Collider gawangDown;
    public Collider gawangLeft;
    public Collider gawangRight;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5 || spawnManager.loseCount.Count >= 3)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
      
            if (collider == gawangUp)
            {
                //Debug.Log("Yes gup" + this);
                scoreManager.AddPlayerUpScore(1);
            }
            else if (collider == gawangDown)
            {
                //Debug.Log("Yes gdown" + this);
                scoreManager.AddPlayerDownScore(1);
            }
            else if (collider == gawangLeft)
            {
                //Debug.Log("Yes gleft" + this);
                scoreManager.AddPlayerLeftScore(1);
            }
            else if (collider == gawangRight)
            {
                //Debug.Log("Yes gright" + this);
                scoreManager.AddPlayerRightScore(1);
            }
        
    }

}
