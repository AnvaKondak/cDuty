using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HumanController : MonoBehaviour
{
    
    public Animator anim;
    public float moveSpeed = 10f;


    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    public float rotationRate = 180;
    private Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        ApplyInput(moveAxis, turnAxis);

      
        if (Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("up"))
        {
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }
        else { anim.SetBool("isWalking", false); }

        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            anim.SetBool("runBack", true);
        }
        else { anim.SetBool("runBack", false); }

        //if (Input.GetKey("d"))
        //{
        //    if (Input.GetKey("h"))
        //    {
        //        anim.SetBool("isRunning", true);
        //    }

        //}
        //else { anim.SetBool("isRunning", false); }
   




    }

    private void ApplyInput(float moveInput, float turnInput) {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        //transform.Translate(Vector3.forward * input * moveSpeed);
        rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }



}
