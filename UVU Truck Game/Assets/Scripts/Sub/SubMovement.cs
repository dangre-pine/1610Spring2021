using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    
    
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2((moveDirection.x * moveSpeed), (moveDirection.y * moveSpeed));
        // rb.velocity = new Vector2((moveDirection.x * moveSpeed), 0);
    }
    
}
