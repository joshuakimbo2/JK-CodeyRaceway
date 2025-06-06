﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CodeyMove : MonoBehaviour
{
    public float Speed = 15f;
    Animator anim;
    public bool running = false;
    public bool canMove = false;
    public Vector3 move;
    public float _rotationSpeed = 50f;
    private Rigidbody rb;
    private float multiplier = 1f;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
    void Update()
    {
        if (canMove)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");            
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = transform.forward * Speed * Time.deltaTime * vertical * multiplier;
            move.y = 0f;
            transform.Rotate(rotation);

            rb.AddForce(move, ForceMode.VelocityChange);

            
            anim.SetFloat("speed", move.magnitude);
        }
        
    }

    public void SetSpeedMultiplier(float mult, float dur)
    {
        multiplier = mult;
        Invoke("ResetMultiplier", dur);
    }

    private void ResetMultiplier()
    {
        multiplier = 1;
    }
}