using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTurtle : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float upMove;
    public float downMove;
    public float leftMove;
    public float rightMove;
    bool turtleIsAlive = true;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.2f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.2f, 0, 0);
        }
    }
}
