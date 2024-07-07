using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float _walkSpeed = 4f;
    public float maxVelocityChange = 10f;
    private Vector2 input;
    private Rigidbody rb;
    private PhotonView _photon;
    
    
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _photon = GetComponent<PhotonView>();




    }
    
    private void FixedUpdate()
    {
        if (_photon.IsMine) { 
            rb.AddForce(CalculateMovement(_walkSpeed), ForceMode.VelocityChange);

            
            
        }

        
  
    }

    private void Update()
    {
        if (_photon.IsMine)
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            input.Normalize();
           
            
        }
    }



    Vector3 CalculateMovement( float _speed)
    {
        Vector3 targetVelocity = new Vector3(input.x, 0f, input.y);
        targetVelocity = transform.TransformDirection(targetVelocity);
        targetVelocity *= _speed;
        Vector3 velocity = rb.velocity;
        if (input.magnitude > 0.5f)
        {
            Vector3 velocityChange = targetVelocity - velocity;
            velocityChange.x = Math.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
            velocityChange.z = Math.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
            velocityChange.y = 0;
            return (velocityChange);
        }
        else
        {
            return new Vector3();
        }
    }



}
