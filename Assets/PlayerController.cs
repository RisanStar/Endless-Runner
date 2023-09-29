using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject groundchecker;
    public LayerMask WhatIsGround;

    public float maxSpeed = 15.0f;
    bool isOnGround = false;
    // Ablew to manipulate the body
    Rigidbody2D playerobject;
    // Start is called before the first frame update
    void Start()
    {
        //Attaches Code to body
        playerobject = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical input
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 13.0f;
        }
        else
        {
            maxSpeed = 5.0f;
        }

        float movementValueX = 2.0f;
        float movementValueY = 2.0f;


        //Velocity
        playerobject.velocity = new Vector2(movementValueX * maxSpeed, playerobject.velocity.y);


        isOnGround = Physics2D.OverlapCircle(groundchecker.transform.position, 1.0f, WhatIsGround);
        if (isOnGround)
        {
            if (Input.GetKey(KeyCode.Space))
                playerobject.velocity = new Vector3(movementValueY * maxSpeed, playerobject.velocity.x);
        }

    }
}