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

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
            spawnManager.RemoveOutSpawnBall(gameObject);
        }

        if (spawnManager.loseCount.Count >= 3)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
            if (collider == gawangUp)
            {
                scoreManager.AddPlayerUpScore(1);
            }
            else if (collider == gawangDown)
            {
                scoreManager.AddPlayerDownScore(1);
            }
            else if (collider == gawangLeft)
            {
                scoreManager.AddPlayerLeftScore(1);
            }
            else if (collider == gawangRight)
            {
                scoreManager.AddPlayerRightScore(1);
            }
        
    }

}
