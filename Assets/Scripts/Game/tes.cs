using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes : MonoBehaviour
{

    enum playerSign { none, playerup, playerdown, playerleft, playerright };
    playerSign currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        currentPlayer = playerSign.none;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerUp"))
        {
            //Debug.Log("Player Up");
            currentPlayer = playerSign.playerup;
            Debug.Log("Player Up " + currentPlayer);
        }
        else if (collision.gameObject.CompareTag("PlayerDown"))
        {
            //Debug.Log("Player Down");
            currentPlayer = playerSign.playerdown;
            //Debug.Log("Player Down " + currentPlayer);
        }
        else if (collision.gameObject.CompareTag("PlayerLeft"))
        {
            //Debug.Log("Player Left");
            currentPlayer = playerSign.playerleft;
        }
        else if (collision.gameObject.CompareTag("PlayerRight"))
        {
            //Debug.Log("Player Right");
            currentPlayer = playerSign.playerright;
        }
    }
}
