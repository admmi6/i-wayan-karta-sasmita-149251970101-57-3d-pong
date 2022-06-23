using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public KeyCode keyForward;
    public KeyCode keyBackward;
    public KeyCode keyLeft;
    public KeyCode keyRight;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = GetInput();
        MoveObject(movement);
    }

    public float NewSpeed()
    {
        return speed / 10;
    }
    private Vector3 GetInput()
    {
        if (Input.GetKey(keyForward))
        {
            return Vector3.forward * speed;
            //transform.Translate(Vector3.forward * NewSpeed());
        }
        else if (Input.GetKey(keyBackward))
        {
            return Vector3.back * speed;
            //transform.Translate(Vector3.back * NewSpeed());
        }
        else if (Input.GetKey(keyLeft))
        {
            return Vector3.left * speed;
            //transform.Translate(Vector3.left * NewSpeed());
        }
        else if (Input.GetKey(keyRight))
        {
            return Vector3.right * speed;
            //transform.Translate(Vector3.right * NewSpeed());
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
