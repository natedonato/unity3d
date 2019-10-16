﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float moveSpeed = 10;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        //transform.position = new Vector3(0, 5, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * moveSpeed;
        Vector3 moveAmount = velocity * Time.deltaTime;
            
        transform.Translate(moveAmount);
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 1000, 0);
        }


    }
}
